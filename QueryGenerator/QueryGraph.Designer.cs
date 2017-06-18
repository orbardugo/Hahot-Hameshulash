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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.testChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exportImgBtn = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.cmbValOrPer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.testChart)).BeginInit();
            this.SuspendLayout();
            // 
            // testChart
            // 
            chartArea1.Name = "CA";
            this.testChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.testChart.Legends.Add(legend1);
            this.testChart.Location = new System.Drawing.Point(3, 12);
            this.testChart.Name = "testChart";
            this.testChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.testChart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.testChart.Size = new System.Drawing.Size(1339, 665);
            this.testChart.TabIndex = 0;
            this.testChart.Text = "chart1";
            title1.Name = "Title1";
            this.testChart.Titles.Add(title1);
            // 
            // exportImgBtn
            // 
            this.exportImgBtn.Location = new System.Drawing.Point(1112, 25);
            this.exportImgBtn.Margin = new System.Windows.Forms.Padding(2);
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
            // cmbValOrPer
            // 
            this.cmbValOrPer.FormattingEnabled = true;
            this.cmbValOrPer.Items.AddRange(new object[] {
            "אחוזים",
            "יחידות",
            "שניהם"});
            this.cmbValOrPer.Location = new System.Drawing.Point(13, 25);
            this.cmbValOrPer.Name = "cmbValOrPer";
            this.cmbValOrPer.Size = new System.Drawing.Size(121, 21);
            this.cmbValOrPer.TabIndex = 3;
            this.cmbValOrPer.Text = "הצג לפי";
            this.cmbValOrPer.SelectedIndexChanged += new System.EventHandler(this.cmbValOrPer_SelectedIndexChanged);
            // 
            // QueryGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 476);
            this.Controls.Add(this.cmbValOrPer);
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
        private System.Windows.Forms.ComboBox cmbValOrPer;
    }
}