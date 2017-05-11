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
        private const string SHEET_NAME = "עדכון נתונים";
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
            openFileDialog1.Filter = "Excel Files (*.xls, *.xlsx)|*.xlsx;*.xls;";
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
                string meetDate = a["תאריך היכרות"];
                Boolean[] attendance = new Boolean[366];
                //getAttendance(a, attendance);

                if (String.IsNullOrEmpty(year))
                {
                    year = UNKNOWN;
                }
                Person p = new Person(Int32.Parse(year), privateName, lastName, gender, city, meetDate);
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
        private void getAttendance(Row a, Boolean[] attendance)
        {
            String month = "ינו-";
            int daysOfMonth = 31, k = 0;
            Boolean leafYear = false;
            for (int i = 1; i <= 7; i++)
            {
                switch (i)
                {
                    case 1:
                        daysOfMonth = 31;
                        month = "ינו-";
                        break;
                    case 2:
                        daysOfMonth = 28;
                        if ((DateTime.Today.Year % 4 == 0 && DateTime.Today.Year % 100 != 0) || DateTime.Today.Year % 400 == 0)
                        {
                            daysOfMonth++;
                            leafYear = true;
                        }
                        month = "פבר-";
                        break;
                    case 3:
                        daysOfMonth = 31;
                        month = "מרץ-";
                        break;
                    case 4:
                        daysOfMonth = 30;
                        month = "אפר-";
                        break;
                    case 5:
                        daysOfMonth = 31;
                        month = "מאי-";
                        break;
                    case 6:
                        daysOfMonth = 30;
                        month = "יונ-";
                        break;
                    case 7:
                        daysOfMonth = 31;
                        month = "יול-";
                        break;
                    case 8:
                        daysOfMonth = 31;
                        month = "אוג-";
                        break;
                    case 9:
                        daysOfMonth = 30;
                        month = "ספט-";
                        break;
                    case 10:
                        daysOfMonth = 31;
                        month = "אוק-";
                        break;
                    case 11:
                        daysOfMonth = 30;
                        month = "נוב-";
                        break;
                    case 12:
                        daysOfMonth = 31;
                        month = "דצמ-";
                        break;

                }
                for (int j = 1; j <= daysOfMonth; j++)
                {
                    if (i == 2 && j == 28 && !leafYear)
                        continue;
                    if (j < 10)
                    {
                        if (a[month + "0" + j] == "1")
                            attendance[k] = true;
                        else
                            attendance[k] = false;
                    }
                    else
                    {
                        if (a[month + j] == "1")
                            attendance[k] = true;
                        else
                            attendance[k] = false;
                    }

                    k++;
                }
            }
        }

    }
}
