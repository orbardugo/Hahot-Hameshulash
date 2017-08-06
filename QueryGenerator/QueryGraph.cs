using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Main Class - creating Quary Graph form
/// </summary>
namespace QueryGenerator
{
    public partial class QueryGraph : Form
    {
        readonly string[] typeCol;
        readonly int[] count;
        readonly string type;
        public QueryGraph(string[] typeCol, int[] count, string type)
        {
            this.type = type;
            this.typeCol = typeCol;
            this.count = count;
            
            this.WindowState = FormWindowState.Maximized;
            
            InitializeComponent();
            genChart(0);

        }

        private void exportImgBtn_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image  
            // assigned to exportImgBtn.  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.  
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the  
                // File type selected in the dialog box.  
                // NOTE that the FilterIndex property is one-based.  
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        testChart.SaveImage(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        testChart.SaveImage(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    default:
                        testChart.SaveImage(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.testChart.Width, this.testChart.Height);
            testChart.DrawToBitmap(bm, new Rectangle(0, 0, this.testChart.Width, this.testChart.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void genChart(int valOrPer)
        {
            string output = null;
            switch (valOrPer)
            {
                case 0:
                    output = "#PERCENT";
                    break;
                case 1:
                    output = "#VALY";
                    break;                
                default:
                    output = "(" + "#VALY" + ") " + "#PERCENT";
                    break;
            }
            var x = new System.Windows.Forms.DataVisualization.Charting.SeriesChartType();
            if (type == "עוגה")
            {
                x = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                cmbValOrPer.Visible = true;
            }
            else if (type == "עמודות")
            {
                x = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                cmbValOrPer.Visible = true;
            }
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
            testChart.Titles.Clear();  
            testChart.Series.Clear();   
            var yourTitle = new System.Windows.Forms.DataVisualization.Charting.Title("החוט המשולש", System.Windows.Forms.DataVisualization.Charting.Docking.Top, new Font("Verdana", 12), Color.Black);
            var yourTitle2 = new System.Windows.Forms.DataVisualization.Charting.Title(string.Format (" גרף מוצג לפי: {0}", QueryGenerator.chartList.SelectedItem.ToString()), System.Windows.Forms.DataVisualization.Charting.Docking.Top, new Font("Verdana", 12), Color.Black);
            testChart.Titles.Add(yourTitle);
            testChart.Titles.Add(yourTitle2);
            testChart.Series.Add(s);
            testChart.ChartAreas[0].Area3DStyle.Enable3D = true;
            testChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8);
            testChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            testChart.Series[0].IsValueShownAsLabel = true;
            testChart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            testChart.ChartAreas[0].AxisY.LabelStyle.Enabled = true;
            foreach (var title in typeCol)
            {
                s.Points.AddXY(title, count[index]);
                if (s.ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie)
                {
                    s.Points[index].Label = string.Format("[{0}] {1}",output,title);
                    s.Points[index].Font = new Font("Arial", 15);
                }
                else if (s.ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column)
                {
                    s.Points[index].Label = string.Format("{0}", output);
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
        private void cmbValOrPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            genChart(cmbValOrPer.SelectedIndex);
        }
    }
}

