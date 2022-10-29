using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitMiracle.LibTiff.Classic;
using System.Drawing;

namespace Tiff2Excel
{
    class TiffData
    {
        string strTiff;
        Tiff refTiff;
        ushort[,] rawData;
        Bitmap bitmap;

        internal bool IsValid { get; } = false;

        internal TiffData(string location)
        {
            strTiff = location;
            refTiff = BitMiracle.LibTiff.Classic.Tiff.Open(location, "r");

            IsValid = refTiff == null ? false : true;

            if (IsValid)
                extractRawData();
        }



        ~TiffData()
        {
            if (refTiff != null)
            {
                refTiff.Close();
            }
        }
        public int getWidth()
        {
            FieldValue[] value = refTiff.GetField(TiffTag.IMAGEWIDTH);
            int width = value[0].ToInt();
            return width;
        }
        public int getHeight()
        {
            FieldValue[] value = refTiff.GetField(TiffTag.IMAGELENGTH);
            int height = value[0].ToInt();
            return height;
        }
        public int getBytesPerSapmle()
        {
            FieldValue[] value = refTiff.GetField(TiffTag.BITSPERSAMPLE);
            int bitpersample = value[0].ToInt();
            return bitpersample/8;
        }
        public string getPath()
        {
            string path;
            path = System.IO.Path.GetDirectoryName(this.strTiff);

            return path;
        }
        public string getFilename()
        {
            return this.strTiff;
        }
        private void extractRawData()
        {
            LogHelper.logger.Trace("extractRawData");
            int width = refTiff.GetField(TiffTag.IMAGEWIDTH)[0].ToInt();
            int height = refTiff.GetField(TiffTag.IMAGELENGTH)[0].ToInt();
            int bytesPerScanline;
            int bytesPerPixel;

            int bytesPerSample = refTiff.GetField(TiffTag.BITSPERSAMPLE)[0].ToInt() / 8;
            int samplePerPixel = refTiff.GetField(TiffTag.SAMPLESPERPIXEL)[0].ToInt();

            //int[,] buffer = new int[height, width];
            ushort[,] buffer = new ushort[height, width];

            bytesPerPixel = samplePerPixel * bytesPerSample;
            bytesPerScanline = width * bytesPerPixel;
            //ushort[,] buffer = new ushort[height, width];

            byte[] scanline = new byte[bytesPerScanline];

            for (int i = 0; i < height; i++)
            {
                refTiff.ReadScanline(scanline, i);

                for (int j = 0; j < width; j++)
                {
                    int temp = 0;
                    for (int b = 0; b < bytesPerPixel; b++)
                    {
                        temp += scanline[j * bytesPerPixel + b] << ((bytesPerPixel - b - 1) * 8);
                    }
                    buffer[i, j] = (ushort)temp;
                }
            }
                /*
                try
                {
                    refTiff.ReadScanline(scanline, i);
                    Buffer.BlockCopy(scanline, 0, buffer, i * width * 2, scanline.Length);
                }
                catch (Exception e)
                {
                    LogHelper.logger.Error("buffer: " + buffer.Length.ToString());
                    LogHelper.logger.Error("scanline: " + scanline.Length.ToString());
                    LogHelper.logger.Error("width: " + width.ToString());
                    LogHelper.logger.Error("i: " + i.ToString());
                    break;
                }
                */
            

            Bitmap bmp = new Bitmap(width, height);
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    bmp.SetPixel(j, i, Color.FromArgb(buffer[i, j] / 256, buffer[i, j] / 256, buffer[i, j] / 256));
                }
            }

            //bmp.Save("ReadSamples.bmp");
            this.bitmap = bmp;
            this.rawData = buffer;
        }

        public Bitmap getBitmap()
        {
            return this.bitmap;

        }
        public ushort[] getCenterSignalVector()
        {
           ushort[] signalVec;
           int centerLine;  

           int width = refTiff.GetField(TiffTag.IMAGEWIDTH)[0].ToInt();
           int height = refTiff.GetField(TiffTag.IMAGELENGTH)[0].ToInt();

            signalVec = new ushort[height];
            centerLine = (width / 2);

            for (int i=0; i < height; i++)
            {
                signalVec[i] = rawData[i, centerLine];
            }

            //signalVec = new ushort[width * height];
            //Buffer.BlockCopy(this.rawData, 0, signalVec, 0, width * height * sizeof(ushort));
            return signalVec;
        }
        public ushort[] getSignalVector(int column)
        {
            ushort[] signalVec;
            int centerLine;

            int width = refTiff.GetField(TiffTag.IMAGEWIDTH)[0].ToInt();
            int height = refTiff.GetField(TiffTag.IMAGELENGTH)[0].ToInt();


            signalVec = new ushort[height];
            if (column > width) return signalVec;

            signalVec = new ushort[height];
            centerLine = (width / 2);

            for (int i = 0; i < height; i++)
            {
                signalVec[i] = rawData[i, column];
            }

            //signalVec = new ushort[width * height];
            //Buffer.BlockCopy(this.rawData, 0, signalVec, 0, width * height * sizeof(ushort));
            return signalVec;
        }
    }
}
