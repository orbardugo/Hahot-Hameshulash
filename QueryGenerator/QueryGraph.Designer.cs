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
            // QueryGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 689);
            this.Controls.Add(this.testChart);
            this.Name = "QueryGraph";
            this.Text = "QueryGraph";
            ((System.ComponentModel.ISupportInitialize)(this.testChart)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart testChart;
    }
}