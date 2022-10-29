using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using BitMiracle.LibTiff.Classic;


namespace Tiff2Excel
{
    public partial class Form1 : Form
    {
        TiffData LoadedImage;


        public Form1()
        {
            InitializeComponent();
            updateGUI();
            LogHelper.startLogging();
        }
        public void updateGUI()
        {
            bool enableButtons = false;

            if (this.LoadedImage != null)
                if (this.LoadedImage.IsValid)
                    enableButtons = true;

             btn_matrixXLS.Enabled = enableButtons;
             btn_vectorTxt.Enabled = enableButtons;
             btn_vectorXLS.Enabled = enableButtons;
             btn_vectorCsv.Enabled = enableButtons;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string filename = null;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            ofd.Filter = "tiff Datei | *.tif";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
            }

            if (filename == null)
            {
                updateGUI();
                return;
            }

            LoadedImage = new TiffData(filename);


            if (LoadedImage.IsValid == false)
            {
                MessageBox.Show("Could not open image!");
                updateGUI();
                return;
            }

            updateGUI();

            showStatus();
            showImage();
            showChart();
        }
        public void showStatus()
        {
            lbl_height.Text = LoadedImage.getHeight().ToString();
            lbl_width.Text = LoadedImage.getWidth().ToString();
            lbl_location.Text = LoadedImage.getFilename();
            //LoadedImage.getBitmap();
        }
        public void showImage()
        {
            Bitmap bitmap = LoadedImage.getBitmap();

            pb_image.Image = bitmap;
        }
        public void showChart()
        {
            ushort[] sig = LoadedImage.getCenterSignalVector();

            this.chart_signal.Series.Clear();

            this.chart_signal.ChartAreas[0].AxisY.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont;
            this.chart_signal.ChartAreas[0].AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont;

            this.chart_signal.ChartAreas[0].IsSameFontSizeForAllAxes = true;
            this.chart_signal.ChartAreas[0].AxisX.LabelAutoFitMaxFontSize = 10;
            this.chart_signal.ChartAreas[0].AxisX.LabelAutoFitMinFontSize = 10;
            this.chart_signal.ChartAreas[0].AxisY.LabelAutoFitMaxFontSize = 10;
            this.chart_signal.ChartAreas[0].AxisY.LabelAutoFitMinFontSize = 10;
            this.chart_signal.ChartAreas[0].AxisX.Title = "line-number";
            this.chart_signal.ChartAreas[0].AxisY.Title = "amplitude";

            this.chart_signal.Series.Add("signal");
            this.chart_signal.Series["signal"].ChartArea = this.chart_signal.ChartAreas[0].Name;
            this.chart_signal.Series["signal"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            this.chart_signal.Series["signal"].Points.DataBindY(sig);
            this.chart_signal.Series["signal"].BorderWidth = 2;
            //this.chart_signal.Series["signal"].
            //this.chart_signal.ChartAreas[0].AxisX.ScaleView.Zoomable = false;
            //this.chart_signal.ChartAreas[0].AxisY.ScaleView.Zoomable = false;
            //this.chart_signal.Titles[0].Text = "Sampled signal";

        }

        private void btn_vectorTxt_Click(object sender, EventArgs e)
        {
            string filename;
            string initialPath;
            SaveFileDialog saveFileDialog;
            StreamWriter writer;
            ushort[] vec;


            initialPath = LoadedImage.getPath();
            filename = String.Empty;

            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog.InitialDirectory = initialPath;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Save Txt File";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
            }
            else
            {
                return;
            }

            vec = LoadedImage.getCenterSignalVector();
            writer = new StreamWriter(filename);

            for (int i = 0; i < vec.Length; i++)
            {
                string temp = vec[i].ToString();

                writer.WriteLine(temp);
            }

            writer.Close();
        }

        private void btn_vectorCsv_Click_1(object sender, EventArgs e)
        {
            string filename;
            string initialPath;
            SaveFileDialog saveFileDialog;
            StreamWriter writer;
            ushort[] vec;


            initialPath = LoadedImage.getPath();
            filename = String.Empty;

            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog.InitialDirectory = initialPath;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Save CSV File";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
            }
            else
            {
                return;
            }

            vec = LoadedImage.getCenterSignalVector();
            writer = new StreamWriter(filename);

            for (int i = 0; i < vec.Length; i++)
            {
                string temp = vec[i].ToString();
                if (i < vec.Length - 1)
                {
                    temp = temp + ",";
                }
                writer.Write(temp);
            }

            writer.Close();
        }

        private void btn_vectorXLS_Click(object sender, EventArgs e)
        {
            XLSHelper writer;
            string filename;
            string initialPath;
            SaveFileDialog saveFileDialog;
            ushort[] vec;


            initialPath = LoadedImage.getPath();
            filename = String.Empty;

            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog.InitialDirectory = initialPath;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Save XLSX File";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.Filter = "XLSX files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
            }
            else
            {
                return;
            }

            vec = LoadedImage.getCenterSignalVector();
            writer = new XLSHelper();
            writer.writeVector(vec,0);
            writer.saveFileAndQuit(filename);
        }

        private void btn_matrixXLS_Click(object sender, EventArgs e)
        {
            XLSHelper writer;
            string filename;
            string initialPath;
            SaveFileDialog saveFileDialog;
            ushort[] vec;

            initialPath = LoadedImage.getPath();
            filename = String.Empty;

            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog.InitialDirectory = initialPath;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Save XLSX File";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.Filter = "XLSX files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
            }
            else
            {
                return;
            }


            MessageBox.Show("Data process please wait...");

            writer = new XLSHelper();

            for (int i = 0; i< LoadedImage.getWidth();i++)
            {
                vec = LoadedImage.getSignalVector(i);
                writer.writeVector(vec, i);
            }


            writer.saveFileAndQuit(filename);
        }
    }
}
