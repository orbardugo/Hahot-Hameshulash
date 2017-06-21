using System;
using System.Collections.Generic;
using System.Linq;
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
            try
            {
                XLSX_PATH = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                var excelFile = new ExcelQueryFactory(XLSX_PATH);
                List<Row> dataBase1 = excelFile.WorksheetRange("A1", "AJ100000", SHEET_NAME).ToList(); // contains private information

                List<RowNoHeader> dataBase2 = excelFile.WorksheetRangeNoHeader("AJ1", "IT1", SHEET_NAME).ToList();
                List<RowNoHeader> dataBase3 = excelFile.WorksheetRangeNoHeader("IU1", "OV1", SHEET_NAME).ToList();
                List<Row> dataBase4 = excelFile.WorksheetRange("AJ1", "IT100000", SHEET_NAME).ToList(); // content of dataBase2
                List<Row> dataBase5 = excelFile.WorksheetRange("IU1", "OV100000", SHEET_NAME).ToList(); // content of dataBase3

                HashSet<string> listOfCities = new HashSet<string>();
                HashSet<string> listOfCurrentOccupation = new HashSet<string>();
                HashSet<string> listOfExternalContact = new HashSet<string>();
                HashSet<string> listOfUseAlcohol = new HashSet<string>();
                HashSet<string> listOfuseDrug = new HashSet<string>();
                HashSet<string> listOfReligion = new HashSet<string>();
                HashSet<string> listOfCriminalRecord = new HashSet<string>();
                HashSet<string> listOfInstitutions = new HashSet<string>();
                HashSet<string> listOfProstitutions = new HashSet<string>();
                HashSet<string> listOfShelter = new HashSet<string>();



                foreach (var a in dataBase1)
                {
                    string year = a["שנת לידה"];
                    string privateName = a["שם "];
                    string lastName = a["משפחה"];
                    string gender = a["מין"];
                    string city = a["איזור מוצא"];
                    string meetDate = a["תאריך היכרות"];
                    string currentOccupation = a["עיסוק נוכחי"];
                    string externalContact = a["קשר עם גורם נוסף"];
                    string useAlcohol = a["שימוש באלכוהול"];
                    string useDrug = a["שימוש בסמים"];
                    string religion = a["רקע"];
                    string criminalRecord = a["רישום פלילי"];
                    string numofinstitutions = a["מס' מוסדות"];
                    string postitutionsequence = a["רצף זנות"];
                    string sheltersequence = a["רצף קורת גג"];


                    if (String.IsNullOrEmpty(year))
                    {
                        year = UNKNOWN;
                    }
                    Person p = new Person(Int32.Parse(year), privateName, lastName, gender, city, meetDate,
                      currentOccupation, externalContact, useAlcohol, useDrug, religion, criminalRecord, numofinstitutions,
                      postitutionsequence, sheltersequence, new Dictionary<DateTime, bool>());
                    listOfPersons.Add(p);
                    listOfCities.Add(city);
                    listOfCurrentOccupation.Add(currentOccupation);
                    listOfExternalContact.Add(externalContact);
                    listOfUseAlcohol.Add(useAlcohol);
                    listOfuseDrug.Add(useDrug);
                    listOfReligion.Add(religion);
                    listOfCriminalRecord.Add(criminalRecord);
                    listOfInstitutions.Add(numofinstitutions);
                    listOfProstitutions.Add(postitutionsequence);
                    listOfShelter.Add(sheltersequence);
                }
           
            

            getAttendance(dataBase2, dataBase4, listOfPersons); // get Attendence until July (include)
            getAttendance(dataBase3, dataBase5, listOfPersons, 8); // get Attendence from Aug 

            QueryGenerator f2 = new QueryGenerator(listOfPersons, listOfCities, listOfCurrentOccupation, listOfExternalContact,
                listOfUseAlcohol, listOfuseDrug, listOfReligion, listOfCriminalRecord,
                listOfInstitutions, listOfProstitutions, listOfShelter);
            f2.Show();
            this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("טעינת הקובץ נכשלה, בחר קובץ תקין." + ex.Message, "החוט המשולש", MessageBoxButtons.OK ,MessageBoxIcon.Error);

            }
        }

        private void getAttendance(List<RowNoHeader> headerBase, List<Row> dataBase, List<Person> listOfPersons, int StartMonth = 1)
        {
            int personsCount = 0;
            foreach (var a in dataBase)
            {
                string header;
                int months = StartMonth, days = 1;
                DateTime date_Val;
                bool bool_val = false;

                for (int i = 0; i < headerBase[0].Count; i++)
                {
                    header = headerBase[0].ElementAt(i);
                    if (isContainNumbers(header))
                    {
                        date_Val = new DateTime(DateTime.Today.Year, months, days);

                        if (a[header] == "1")
                        {
                            bool_val = true;
                        }
                        else
                        {
                            bool_val = false;
                        }

                        listOfPersons[personsCount].Presence.Add(date_Val, bool_val);
                        days++;
                    }
                    else
                    {
                        months++;
                        days = 1;
                    }
                }
                personsCount++;
            }
        }

        private static bool isContainNumbers(string str)
        {
            bool allCharactersInStringAreDigits = str.Any(char.IsDigit);
            return allCharactersInStringAreDigits;
        }
    }
}
