namespace QueryGenerator
{
    partial class QueryGraph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.testChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exportImgBtn = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.testChart)).BeginInit();
            this.SuspendLayout();
            // 
            // testChart
            // 
            chartArea3.Name = "CA";
            this.testChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.testChart.Legends.Add(legend3);
            this.testChart.Location = new System.Drawing.Point(3, 12);
            this.testChart.Name = "testChart";
            this.testChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.testChart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.testChart.Size = new System.Drawing.Size(1339, 665);
            this.testChart.TabIndex = 0;
            this.testChart.Text = "chart1";
            title3.Name = "Title1";
            this.testChart.Titles.Add(title3);
            // 
            // exportImgBtn
            // 
            this.exportImgBtn.Location = new System.Drawing.Point(1112, 25);
            this.exportImgBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exportImgBtn.Name = "exportImgBtn";
            this.exportImgBtn.Size = new System.Drawing.Size(78, 25);
            this.exportImgBtn.TabIndex = 1;
            this.exportImgBtn.Text = "Save Image";
            this.exportImgBtn.UseVisualStyleBackColor = true;
            this.exportImgBtn.Click += new System.EventHandler(this.exportImgBtn_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::QueryGenerator.Properties.Resources.printer_icon__icon_search_engine_1;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Location = new System.Drawing.Point(1073, 26);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(34, 24);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // QueryGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 476);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.exportImgBtn);
            this.Controls.Add(this.testChart);
            this.Name = "QueryGraph";
            this.Text = "QueryGraph";
            ((System.ComponentModel.ISupportInitialize)(this.testChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart testChart;
        private System.Windows.Forms.Button exportImgBtn;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}