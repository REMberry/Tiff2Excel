namespace Tiff2Excel
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_vectorCsv = new System.Windows.Forms.Button();
            this.btn_matrixXLS = new System.Windows.Forms.Button();
            this.btn_vectorXLS = new System.Windows.Forms.Button();
            this.btn_vectorTxt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart_signal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_location = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.lbl_height = new System.Windows.Forms.Label();
            this.lbl_width = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_signal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 63);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(119, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jörgs Tiff2Excel Konverter (V0.1)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 89);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_vectorCsv);
            this.groupBox2.Controls.Add(this.btn_matrixXLS);
            this.groupBox2.Controls.Add(this.btn_vectorXLS);
            this.groupBox2.Controls.Add(this.btn_vectorTxt);
            this.groupBox2.Location = new System.Drawing.Point(3, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export";
            // 
            // btn_vectorCsv
            // 
            this.btn_vectorCsv.Location = new System.Drawing.Point(138, 28);
            this.btn_vectorCsv.Name = "btn_vectorCsv";
            this.btn_vectorCsv.Size = new System.Drawing.Size(125, 23);
            this.btn_vectorCsv.TabIndex = 3;
            this.btn_vectorCsv.Text = "Vector to .csv";
            this.btn_vectorCsv.UseVisualStyleBackColor = true;
            this.btn_vectorCsv.Click += new System.EventHandler(this.btn_vectorCsv_Click_1);
            // 
            // btn_matrixXLS
            // 
            this.btn_matrixXLS.Location = new System.Drawing.Point(400, 28);
            this.btn_matrixXLS.Name = "btn_matrixXLS";
            this.btn_matrixXLS.Size = new System.Drawing.Size(125, 23);
            this.btn_matrixXLS.TabIndex = 2;
            this.btn_matrixXLS.Text = "Matrix to .xls";
            this.btn_matrixXLS.UseVisualStyleBackColor = true;
            this.btn_matrixXLS.Click += new System.EventHandler(this.btn_matrixXLS_Click);
            // 
            // btn_vectorXLS
            // 
            this.btn_vectorXLS.Location = new System.Drawing.Point(269, 28);
            this.btn_vectorXLS.Name = "btn_vectorXLS";
            this.btn_vectorXLS.Size = new System.Drawing.Size(125, 23);
            this.btn_vectorXLS.TabIndex = 1;
            this.btn_vectorXLS.Text = "Vector to .xls";
            this.btn_vectorXLS.UseVisualStyleBackColor = true;
            this.btn_vectorXLS.Click += new System.EventHandler(this.btn_vectorXLS_Click);
            // 
            // btn_vectorTxt
            // 
            this.btn_vectorTxt.Location = new System.Drawing.Point(6, 28);
            this.btn_vectorTxt.Name = "btn_vectorTxt";
            this.btn_vectorTxt.Size = new System.Drawing.Size(125, 23);
            this.btn_vectorTxt.TabIndex = 0;
            this.btn_vectorTxt.Text = "Vector to .txt";
            this.btn_vectorTxt.UseVisualStyleBackColor = true;
            this.btn_vectorTxt.Click += new System.EventHandler(this.btn_vectorTxt_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.chart_signal);
            this.panel3.Controls.Add(this.pb_image);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 309);
            this.panel3.TabIndex = 2;
            // 
            // chart_signal
            // 
            this.chart_signal.BorderlineColor = System.Drawing.SystemColors.GrayText;
            this.chart_signal.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            this.chart_signal.ChartAreas.Add(chartArea1);
            this.chart_signal.Location = new System.Drawing.Point(273, 99);
            this.chart_signal.Name = "chart_signal";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            series1.Name = "Series1";
            this.chart_signal.Series.Add(series1);
            this.chart_signal.Size = new System.Drawing.Size(255, 204);
            this.chart_signal.TabIndex = 2;
            this.chart_signal.Text = "chart_signal";
            // 
            // pb_image
            // 
            this.pb_image.BackColor = System.Drawing.Color.White;
            this.pb_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_image.Location = new System.Drawing.Point(12, 99);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(255, 204);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 1;
            this.pb_image.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_width);
            this.groupBox1.Controls.Add(this.lbl_height);
            this.groupBox1.Controls.Add(this.lbl_location);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_load);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load Tiff-Data:";
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Location = new System.Drawing.Point(73, 57);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(25, 16);
            this.lbl_location.TabIndex = 4;
            this.lbl_location.Text = "../..";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location:";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(10, 21);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(102, 23);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Open File";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(204, 24);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(17, 16);
            this.lbl_height.TabIndex = 5;
            this.lbl_height.Text = "...";
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Location = new System.Drawing.Point(315, 24);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(17, 16);
            this.lbl_width.TabIndex = 6;
            this.lbl_width.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(540, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Tiff2Excel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_signal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_vectorTxt;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_signal;
        private System.Windows.Forms.Button btn_vectorXLS;
        private System.Windows.Forms.Button btn_matrixXLS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Button btn_vectorCsv;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Label lbl_height;
    }
}

