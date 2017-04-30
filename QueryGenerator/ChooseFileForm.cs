using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToExcel;

namespace QueryGenerator
{
    public partial class ChooseFileForm : Form
    {
        private string XLSX_PATH;
        private const string SHEET_NAME = "ארכיון";
        private Boolean isSucceded;
        private List<Person> listOfPersons;
        private const string UNKNOWN = "-1";

        public ChooseFileForm()
        {
            InitializeComponent();
            listOfPersons = new List<Person>();
        }


        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                    sr.Close();
                    isSucceded = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    isSucceded = false;
                }
            }
            if (isSucceded == false) // couldnt read the file
            {
                listOfPersons = null;
                return;
            }

            XLSX_PATH = openFileDialog1.InitialDirectory + openFileDialog1.FileName;


            var excelFile = new ExcelQueryFactory(XLSX_PATH);
            var dataBase = from name in excelFile.Worksheet(SHEET_NAME) select name;
            HashSet<string> listOfCities = new HashSet<string>();

            foreach (var a in dataBase)
            {
                string year = a["שנת לידה"];
                string privateName = a["שם "];
                string lastName = a["משפחה"];
                string gender = a["מין"];
                string city = a["עיר מוצא"];

                if (String.IsNullOrEmpty(year))
                {
                    year = UNKNOWN;
                }
                Person p = new Person(Int32.Parse(year), privateName, lastName, gender, city);
                listOfPersons.Add(p);
                listOfCities.Add(city);
            }
        
            QueryGenerator f2 = new QueryGenerator(listOfPersons,listOfCities);
            f2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
