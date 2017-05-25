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
    public partial class QueryGenerator : Form
    {
        private List<Person> listOPepoles;
        private HashSet<string> hashSetOfCities;
        private HashSet<string> hashSetCurrentOccupation;
        private HashSet<string> hashSetExternalContact;
        private HashSet<string> hashSetUseAlcohol;
        private HashSet<string> hashSetUseDrug;
        private HashSet<string> hashSetReligion;
        private HashSet<string> hashSetlistOfCriminalRecord;
        private IEnumerable<Person> mainQuery;
        private IEnumerable<Person> listAfterQuery;

        //==================Queries Variables=========================
        private String genderValue = null;

        private int fromAge = 0, toAge = 0;
        private String city = null;
        private String drug = null;
        private bool FindAppearance;
        private DateTime appStartDate, appEndDate;
        private String alcohol = null;
        private String religion = null;
        private String occupation = null;
        private String criminalRecord = null;
        private String externalContact = null;

        public QueryGenerator(List<Person> listOfPepoles, HashSet<string> hashSetOfcities, HashSet<string> hashSetCurrentoccupation, HashSet<string> hashSetExternalcontact
            , HashSet<string> hashSetUsealcohol, HashSet<string> hashSetUsedrug, HashSet<string> hashSetreligion, HashSet<string> hashSetlistOfCriminalrecord)
        {
            try
            {
                panelResults.Width = (int)(Console.WindowWidth * 0.7);
                panelResults.Height = (int)(Console.WindowHeight * 0.9);
                queryBox.Width = (int)(Console.WindowWidth * 0.3);
                queryBox.Height = (int)(Console.WindowHeight * 0.4);
                QueryListBox.Width = (int)(Console.WindowWidth * 0.3);
                QueryListBox.Height = (int)(Console.WindowHeight * 0.4);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            listOPepoles = listOfPepoles;
            hashSetOfCities = hashSetOfcities;
            hashSetCurrentOccupation = hashSetCurrentoccupation;
            hashSetExternalContact = hashSetExternalcontact;
            hashSetUseAlcohol = hashSetUsealcohol;
            hashSetUseDrug = hashSetUsedrug;
            hashSetReligion = hashSetreligion;
            hashSetlistOfCriminalRecord = hashSetlistOfCriminalrecord;
            mainQuery = from p in listOPepoles select p;
            listAfterQuery = mainQuery;
            InitializeComponent();
        }
        //==========================checked change=====================================
        //========================choose query=========================================
        private void cb_gender_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_gender.Checked)
            {
                unCheckedAllBut(cb_gender);
                panelGender.BringToFront();
                cb_gender.Checked = true;
                disableVisabilityPanels();
                panelGender.Visible = true;

            }
            else
            {
                panelGender.Visible = false;
            }
        }

        private void cb_age_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_age.Checked)
            {
                unCheckedAllBut(cb_age);
                panelAge.BringToFront();
                cb_age.Checked = true;
                disableVisabilityPanels();
                panelAge.Visible = true;
            }
            else
            {
                panelAge.Visible = false;
            }

        }
        private void cb_alcohol_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_alcohol.Checked)
            {
                unCheckedAllBut(cb_alcohol);
                panelAlcohol.BringToFront();
                disableVisabilityPanels();
                AlcoholCB.Items.Clear();
                AlcoholCB.Items.AddRange(hashSetUseAlcohol.ToArray());
                panelAlcohol.Visible = true;
            }
            else
            {
                panelAlcohol.Visible = false;
            }
        }
        private void cb_useDrug_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_useDrug.Checked)
            {
                unCheckedAllBut(cb_useDrug);
                panelDrug.BringToFront();
                disableVisabilityPanels();
                drugsCB.Items.Clear();
                drugsCB.Items.AddRange(hashSetUseDrug.ToArray());
                panelDrug.Visible = true;
            }
            else
            {
                panelDrug.Visible = false;
            }
            
        }

        private void cb_religion_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_religion.Checked)
            {
                unCheckedAllBut(cb_religion);
                panelReligion.BringToFront();
                disableVisabilityPanels();
                religionCB.Items.Clear();
                religionCB.Items.AddRange(hashSetReligion.ToArray());
                panelReligion.Visible = true;
            }
            else
            {
                panelReligion.Visible = false;
            }

        }

        private void cb_occupation_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_occupation.Checked)
            {
                unCheckedAllBut(cb_occupation);
                panelOccupation.BringToFront();
                disableVisabilityPanels();
                occupationCB.Items.Clear();
                occupationCB.Items.AddRange(hashSetCurrentOccupation.ToArray());
                panelOccupation.Visible = true;
            }
            else
            {
                panelOccupation.Visible = false;
            }

        }

        private void cb_criminalRecord_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_criminalRecord.Checked)
            {
                unCheckedAllBut(cb_criminalRecord);
                panelCriminalRecord.BringToFront();
                disableVisabilityPanels();
                criminalRecordCB.Items.Clear();
                criminalRecordCB.Items.AddRange(hashSetlistOfCriminalRecord.ToArray());
                panelCriminalRecord.Visible = true;
            }
            else
            {
                panelCriminalRecord.Visible = false;
            }
        }

        private void cb_city_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_city.Checked)
            {
                unCheckedAllBut(cb_city);
                disableVisabilityPanels();
                panelCity.BringToFront();
                cityCB.Items.Clear();
                cityCB.Items.AddRange(hashSetOfCities.ToArray());
                panelCity.Visible = true;
            }
            else
            {
                panelCity.Visible = false;
            }
        }

        private void cb_externalContact_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_externalContact.Checked)
            {
                unCheckedAllBut(cb_externalContact);
                panelExternalContact.BringToFront();
                disableVisabilityPanels();
                externalContactCB.Items.Clear();
                externalContactCB.Items.AddRange(hashSetExternalContact.ToArray());
                panelExternalContact.Visible = true;
            }
            else
            {
                panelExternalContact.Visible = false;
            }
        }

        private void unCheckAllCB()
        {
            cb_externalContact.Checked = false;
            cb_city.Checked = false;
            cb_criminalRecord.Checked = false;
            cb_occupation.Checked = false;
            cb_religion.Checked = false;
            cb_useDrug.Checked = false;
            cb_drug.Checked = false;
            cb_alcohol.Checked = false;
            cb_age.Checked = false;
            cb_gender.Checked = false;
        }
        private void disableVisabilityPanels()
        {
            panelCity.Visible = false;
            panelGender.Visible = false;
            panelAge.Visible = false;
            panelAlcohol.Visible = false;
            panelDate.Visible = false;
            panelDrug.Visible = false;
            panelReligion.Visible = false;
            panelOccupation.Visible = false;          
            panelCriminalRecord.Visible = false;
            panelExternalContact.Visible = false;

            panelCity.Location = new Point(this.panelGender.Location.X, this.panelGender.Location.Y);
            panelDrug.Location = new Point(this.panelGender.Location.X, this.panelGender.Location.Y);
            panelExternalContact.Location = new Point(this.panelGender.Location.X, this.panelGender.Location.Y);
            panelOccupation.Location = new Point(this.panelGender.Location.X, this.panelGender.Location.Y);
            panelCriminalRecord.Location = new Point(this.panelGender.Location.X, this.panelGender.Location.Y);
            panelReligion.Location = new Point(this.panelGender.Location.X, this.panelGender.Location.Y);
            panelAge.Location = new Point(this.panelGender.Location.X, this.panelGender.Location.Y);
            panelAlcohol.Location= new Point(this.panelGender.Location.X, this.panelGender.Location.Y);
            panelDate.Location = new Point(this.panelGender.Location.X, this.panelGender.Location.Y);
        }

        


        private void createListFromQuery_Click(object sender, EventArgs e)
        {
            if (genderValue != null)
            {
                listAfterQuery = from person in listAfterQuery
                                 where person.gender == genderValue
                                 orderby person.firstName ascending
                                 select person;
            }
            if (fromAge != 0 && toAge != 0)
            {
                listAfterQuery = from person in listAfterQuery
                                 where person.age >= fromAge && person.age <= toAge
                                 orderby person.firstName ascending
                                 select person;
            }
            if (city != null)
            {
                listAfterQuery = from person in listAfterQuery
                                 where person.city == city
                                 orderby person.firstName ascending
                                 select person;
            }
            if(drug!=null)
            {
                listAfterQuery = from person in listAfterQuery
                                 where person.UseDrug == drug
                                 orderby person.firstName ascending
                                 select person;
            }
            if(alcohol!=null)
            {
                listAfterQuery = from person in listAfterQuery
                                 where person.UseAlcohol == alcohol
                                 orderby person.firstName ascending
                                 select person;
            }
            if(religion!=null)
            {
                listAfterQuery = from person in listAfterQuery
                                 where person.Religion == religion
                                 orderby person.firstName ascending
                                 select person;
            }
            if (occupation != null)
            {
                listAfterQuery = from person in listAfterQuery
                                 where person.CurrentOccupation == occupation
                                 orderby person.firstName ascending
                                 select person;
            }
            if(criminalRecord!=null)
            {
                listAfterQuery = from person in listAfterQuery
                                 where person.CriminalRecord == criminalRecord
                                 orderby person.firstName ascending
                                 select person;
            }
            if(externalContact!=null)
            {
                listAfterQuery = from person in listAfterQuery
                                 where person.ExternalContact == externalContact
                                 orderby person.firstName ascending
                                 select person;
            }
            if (FindAppearance)
            {
                foreach (DateTime day in EachDay(appStartDate, appEndDate))
                {
                    listAfterQuery = from person in listAfterQuery
                                     where person.Presence[day] == true
                                     orderby person.firstName ascending
                                     select person;
                }
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("שם פרטי", typeof(string));
            dt.Columns.Add("שם משפחה", typeof(string));
            dt.Columns.Add("גיל", typeof(int));
            dt.Columns.Add("מין", typeof(string));
            dt.Columns.Add("עיר", typeof(string));
            int sum = 0;

            StringBuilder str = new StringBuilder();
            foreach (Person p in listAfterQuery)
            {
                dt.Rows.Add(p.firstName, p.lastName, p.age, p.gender, p.city);
                sum++;
            }
            dataListGrid.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //ClearGenderPanel
            genderValue = null;
            if (Radio_men.Checked)
                Radio_men.Checked = !Radio_men.Checked;
            if (Radio_woman.Checked)
                Radio_woman.Checked = !Radio_woman.Checked;
            if (Radio_unknowGender.Checked)
                Radio_unknowGender.Checked = !Radio_unknowGender.Checked;
            //ClearAgePanel
            fromAge = 15;
            ageFromNumeric.Value = 15;
            toAge = 24;
            ageToNumeric.Value = 24;
            //ClearCityPanel
            if (city != null)
            {
                cityCB.SelectedIndex = 0;
                city = null;
            }
            //ClearAlcohol
            if (alcohol != null)
            {
                AlcoholCB.SelectedIndex = 0;
                alcohol = null;
            }
            //clear drug
            if (drug != null)
            {
                drugsCB.SelectedIndex = 0;
                drug = null;
            }
            //ClearReligion
            if (religion != null)
            {
                religionCB.SelectedIndex = 0;
                religion = null;
            }
            //ClearOccupation
            if (occupation != null)
            {
                occupationCB.SelectedIndex = 0;
                occupation = null;
            }
            //ClearCrimialRecord
            if (criminalRecord != null)
            {
                criminalRecordCB.SelectedIndex = 0;
                criminalRecord = null;
            }
            if (externalContact != null)
            {
                externalContactCB.SelectedIndex = 0;
                externalContact = null;
            }

            //ClearQueryPanel
            listAfterQuery = mainQuery;
            QueryListBox.Items.Clear();
            //ClearTable
            dataListGrid.DataSource = null;

            disableVisabilityPanels();
            unCheckAllCB();
        }


        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (QueryListBox.SelectedIndex >= 0)
            {
                QueryListBox.Items.RemoveAt(QueryListBox.SelectedIndex);
            }
        }



        private void appearanceCB_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_drug.Checked)
            {
                unCheckedAllBut(cb_drug);
                disableVisabilityPanels();
                panelDate.Visible = true;
            }
            else
            {
                panelDate.Visible = false;
            }
        }

        private void unCheckedAllBut(CheckBox cb)
        {
            if (cb != cb_alcohol)
                cb_alcohol.Checked = false;
            if (cb != cb_drug)
                cb_drug.Checked = false;
            if (cb != cb_city)
                cb_city.Checked = false;
            if (cb != cb_gender)
                cb_gender.Checked = false;
            if (cb != cb_age)
                cb_age.Checked = false;
            if (cb != cb_useDrug)
                cb_useDrug.Checked = false;
            if (cb != cb_religion)
                cb_religion.Checked = false;
            if (cb != cb_occupation)
                cb_occupation.Checked = false;
            if (cb != cb_criminalRecord)
                cb_criminalRecord.Checked = false;
            if (cb != cb_externalContact)
                cb_externalContact.Checked = false;


        }

        private void generateChart_Click(object sender, EventArgs e)
        {
            String query = chartList.SelectedItem.ToString();
            String graphType = cb_chartType.SelectedItem.ToString();
            String[] titles = new String[0];
            String[] genderArray = { "זכר", "נקבה", "אחר" };
            String[] ageArray = { "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" };
            switch (query){
                case "מין":
                    titles = genderArray;
                    break;
                case "עיר":
                    titles = hashSetOfCities.ToArray();
                    break;
                case "רקע":
                    titles = hashSetReligion.ToArray();
                    break;
                case "גיל":
                    titles = ageArray;
                    break;
                case "שימוש באלכוהול":
                    titles = hashSetUseAlcohol.ToArray();
                    break;
                case "שימוש בסמים":
                    titles = hashSetUseDrug.ToArray();
                    break;
            }
            int[] counter = new int[titles.Length];
            foreach(var person in listAfterQuery)
            {
                for(int i=0;i<titles.Length;i++)
                {
                    if (query == "מין")
                    {
                        if (person.gender != "זכר" && person.gender != "נקבה")
                        {
                            counter[2]++;
                            break;
                        }
                        else if (person.gender == titles[i])
                            counter[i]++;
                    }
                    if (query == "עיר")
                        if (person.city == titles[i])
                            counter[i]++;
                    if (query == "רקע")
                        if (person.Religion == titles[i])
                            counter[i]++;
                    if (query == "גיל")
                        if (person.age == int.Parse(titles[i]))
                            counter[i]++;
                    if (query == "שימוש באלכוהול")
                        if (person.UseAlcohol == titles[i])
                            counter[i]++;
                    if (query == "שימוש בסמים")
                        if (person.UseDrug == titles[i])
                            counter[i]++;
                }
            }
            QueryGraph g = new QueryGraph(titles,counter,graphType);
            g.Visible = true;
        }

        private void addQueryBtn_Click(object sender, EventArgs e)
        {
            if (panelGender.Visible)
            {
                //string genderValue;
                if (Radio_men.Checked)
                {
                    genderValue = "זכר";
                }
                else if (Radio_woman.Checked)
                {
                    genderValue = "נקבה";
                }
                else
                {
                    genderValue = "";
                }

                QueryListBox.Items.Add("לפי מין: " + genderValue);
            }
            if (panelAge.Visible)
            {
                fromAge = (int)ageFromNumeric.Value;
                toAge = (int)ageToNumeric.Value;
                QueryListBox.Items.Add("טווח גילאים: " + fromAge + " - " + toAge);
            }
            if (panelCity.Visible && cityCB.SelectedItem!=null)
            {
              
                city = cityCB.SelectedItem.ToString();
                QueryListBox.Items.Add("לפי עיר: " + city);
            }
            if (panelAlcohol.Visible && AlcoholCB.SelectedItem != null)
            {
                alcohol = AlcoholCB.SelectedItem.ToString();
                QueryListBox.Items.Add("שימוש באלכוהול: " + alcohol);
            }
            if(panelDrug.Visible && drugsCB.SelectedItem != null)
            {
                drug = drugsCB.SelectedItem.ToString();
                QueryListBox.Items.Add("שימוש בסמים: " + drug);
            }
            if (panelReligion.Visible && religionCB.SelectedItem != null)
            {
                religion = religionCB.SelectedItem.ToString();
                QueryListBox.Items.Add("דת: " + religion);
            }
            if (panelOccupation.Visible && occupationCB.SelectedItem != null)
            {
                occupation = occupationCB.SelectedItem.ToString();
                QueryListBox.Items.Add("עיסוק נוכחי: " + occupation);
            }
            if (panelCriminalRecord.Visible && criminalRecordCB.SelectedItem != null)
            {
                criminalRecord = criminalRecordCB.SelectedItem.ToString();
                QueryListBox.Items.Add("רישום פלילי: " + criminalRecord);
            }
            if (panelExternalContact.Visible && externalContactCB.SelectedItem != null)
            {
                externalContact = externalContactCB.SelectedItem.ToString();
                QueryListBox.Items.Add("קשר עם גורם נוסף: " + externalContact);
            }
            if (panelDate.Visible)
            {
                appStartDate = dateStart.Value.Date;
                appEndDate = dateEnd.Value.Date;
                FindAppearance = true;
                QueryListBox.Items.Add(string.Format("From: {0} To: {1}", appStartDate.ToString("d"), appEndDate.ToString("d")));
            }
        }
        private IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }
    }
}

