using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryGenerator
{
    public partial class QueryGraph : Form
    {
        public QueryGraph(String[] typeCol, int[] count,String type)
        {
            try
            {
                testChart.Width = (int)(Console.WindowWidth * 0.9);
                testChart.Height = (int)(Console.WindowHeight * 0.9);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            InitializeComponent();
            var x = new System.Windows.Forms.DataVisualization.Charting.SeriesChartType();
            if (type == "עוגה")
                x = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            else if(type== "עמודות")
                x = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            int index = 0;
            var s = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "A",
                AxisLabel = "A",
                Color = System.Drawing.Color.Blue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = x

            };
            testChart.Titles.Clear();   // Unnecessary if you have already clear
            var yourTitle = new System.Windows.Forms.DataVisualization.Charting.Title("גרף מוצג לפי:", System.Windows.Forms.DataVisualization.Charting.Docking.Top, new Font("Verdana", 12), Color.Black);
            testChart.Titles.Add(yourTitle);
            testChart.Series.Add(s);
            testChart.ChartAreas[0].Area3DStyle.Enable3D = true;
            testChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8);
            testChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            testChart.Series[0].IsValueShownAsLabel = true;
            testChart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            testChart.ChartAreas[0].AxisY.LabelStyle.Enabled = true ;
            foreach (var title in typeCol)
            {
                s.Points.AddXY(title, count[index]);
                if (s.ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie)
                {
                    s.Points[index].Label = "#VALY" + " " + title;
                    s.Points[index].Font = new Font("Arial", 15);
                }
                index++;
            }
            Random random = new Random();
            foreach (var item in testChart.Series[0].Points)
            {
                Color c = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                item.Color = c;
            }
        }
    }
}

