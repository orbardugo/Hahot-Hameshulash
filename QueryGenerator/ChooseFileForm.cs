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
        private const string UNKNOWN = "0";

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
            List<Row> dataBase1 = excelFile.WorksheetRange("A1", "IU100000", SHEET_NAME).ToList();
            List<Row> dataBase2 = excelFile.WorksheetRange("IV1", "ZZ100000", SHEET_NAME).ToList();
            //List<Row> mainData = new List<Row>(700);
            //CombineRows(dataBase1, dataBase2, mainData);

            // var dataBase = from name in excelFile.Worksheet(SHEET_NAME) select name;
            HashSet<string> listOfCities = new HashSet<string>();
            HashSet<string> listOfCurrentOccupation = new HashSet<string>();
            HashSet<string> listOfExternalContact = new HashSet<string>();
            HashSet<string> listOfUseAlcohol = new HashSet<string>();
            HashSet<string> listOfuseDrug = new HashSet<string>();
            HashSet<string> listOfReligion = new HashSet<string>();
            HashSet<string> listOfCriminalRecord = new HashSet<string>();

            foreach (var a in dataBase1)
            {
                string year = a["שנת לידה"];
                string privateName = a["שם "];
                string lastName = a["משפחה"];
                string gender = a["מין"];
                string city = a["עיר מוצא"];
                string meetDate = a["תאריך היכרות"];
                string currentOccupation = a["עיסוק נוכחי"];
                string externalContact = a["קשר עם גורם נוסף"];
                string useAlcohol = a["שימוש באלכוהול"];
                string useDrug = a["שימוש בסמים"];
                string religion = a["רקע"];
                string criminalRecord = a["רישום פלילי"];
                Dictionary<DateTime, bool> attendance = new Dictionary<DateTime, bool>(366);
                getAttendance(a, attendance); // get Attendance until Aug-02

                if (String.IsNullOrEmpty(year))
                {
                    year = UNKNOWN;
                }
                Person p = new Person(Int32.Parse(year), privateName, lastName, gender, city, meetDate,
                  currentOccupation, externalContact, useAlcohol, useDrug, religion, criminalRecord, attendance);
                listOfPersons.Add(p);
                listOfCities.Add(city);
                listOfCurrentOccupation.Add(currentOccupation);
                listOfExternalContact.Add(externalContact);
                listOfUseAlcohol.Add(useAlcohol);
                listOfuseDrug.Add(useDrug);
                listOfReligion.Add(religion);
                listOfCriminalRecord.Add(criminalRecord);
            }
            int i = 0;
            foreach (var a in dataBase2)
            {
                getAttendance(a, listOfPersons[i].Presence, 8, 12);
                i++;
            }

            QueryGenerator f2 = new QueryGenerator(listOfPersons, listOfCities, listOfCurrentOccupation, listOfExternalContact,
                listOfUseAlcohol, listOfuseDrug, listOfReligion, listOfCriminalRecord);
            f2.Show();
            this.Hide();
        }

        private void getAttendance(Row a, Dictionary<DateTime, bool> attendance, int startMonth = 1, int endMonth = 8)
        {
            string month = "ינו-";
            int daysOfMonth = 31;
            for (int i = startMonth; i <= endMonth; i++)
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
                        { // leaf year
                            daysOfMonth++;
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
                    string s_date;
                    DateTime D_date;

                    //we're assuming the excel file is correct
                    if (startMonth == 8 && i == 8 && j == 1)
                        j = 2; // reading dataBase2 from Aug 02
                    D_date = new DateTime(DateTime.Today.Year, i, j);
                    if (j < 10)
                    {
                        if (startMonth == 1 && i == 8 && j == 2)
                            return; // end of reading dataBase1 - until Aug 02 (not included)
                        s_date = month + "0" + j;
                        if (a[s_date] == "1")
                            attendance.Add(D_date, true);
                        else
                            attendance.Add(D_date, false);
                    }
                    else
                    {
                        s_date = month + j;
                        if (a[s_date] == "1")
                            attendance.Add(D_date, true);
                        else
                            attendance.Add(D_date, false);
                    }
                }
            }
        }
    }
}
