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
    /// <summary>
    /// Query Generator Form
    /// </summary>
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
        private string genderValue = null;

        private int fromAge = 0, toAge = 0;
        private string city = null;
        private string drug = null;
        private bool FindAppearance;
        private DateTime appStartDate, appEndDate;
        private string alcohol = null;
        private string religion = null;
        private string occupation = null;
        private string criminalRecord = null;
        private string externalContact = null;

        public QueryGenerator(List<Person> listOfPepoles, HashSet<string> hashSetOfcities, HashSet<string> hashSetCurrentoccupation, HashSet<string> hashSetExternalcontact
            , HashSet<string> hashSetUsealcohol, HashSet<string> hashSetUsedrug, HashSet<string> hashSetreligion, HashSet<string> hashSetlistOfCriminalrecord)
        {
            InitializeComponent();
            try
            {
                Rectangle rect = Screen.FromHandle(this.Handle).WorkingArea;
                rect.Location = new Point(0, 0);
                this.MaximizedBounds = rect;
                this.WindowState = FormWindowState.Maximized;
                panelResults.Width = (int)(this.Width * 0.7);
                panelResults.Height = (int)(this.Height - panelGraph.Height);
                panelResults.Location = new Point((int)(this.Width * 0.02), 0);
                dataListGrid.Size = new Size(panelResults.Width - (int)(this.Width * 0.02), (int)(this.panelResults.Height - label1.Height - (int)(this.Height * 0.04)));
                panelGraph.Location = new Point(panelResults.Width / 2 - panelGraph.Width / 2, this.Height - panelGraph.Height - (int)(this.Height * 0.02));
                panelChooseQuery.Width = (int)(this.Width * 0.3);
                panelChooseQuery.Height = (int)(label2.Height + panelQuery.Height + addQueryBtn.Height + (int)(this.Height * 0.02));
                panelChooseQuery.Location = new Point(panelResults.Width + (int)(this.Width * 0.02), 0);
                panelChooseQuery.Paint += delegate (object o, PaintEventArgs p)
                {
                    p.Graphics.Clear(Color.FromArgb(255, 192, 128));
                };

                queryBox.Width = (int)(this.Width * 0.3);
                queryBox.Location = new Point(panelResults.Width + (int)(this.Width * 0.02), panelChooseQuery.Location.Y + panelChooseQuery.Height);
                queryBox.Height = (int)(this.Height * 0.3);
                QueryListBox.Size = new Size(queryBox.Width - (int)(queryBox.Width * 0.01), queryBox.Height - btnClear.Height);
                QueryListBox.Location = new Point(0, 0);
                remove.Location = new Point(QueryListBox.Width - remove.Width, QueryListBox.Height);
                btnClear.Location = new Point(0, QueryListBox.Height);
                label2.Location = new Point(queryBox.Width / 2 - label2.Width / 2, (int)(this.Height * 0.01));
                addQueryBtn.Location = new Point(queryBox.Width / 2 - addQueryBtn.Width / 2, panelQuery.Height + label2.Height + (int)(this.Height * 0.01));
                panelQuery.Location = new Point(panelChooseQuery.Width - panelQuery.Width, label2.Height);
                createListFromQuery.Location = new Point(queryBox.Location.X + (queryBox.Width / 2 - createListFromQuery.Width / 2), panelGraph.Location.Y);
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

            panelCity.Location = new Point(0, label2.Height + (int)(this.Height * 0.06));
            panelDrug.Location = new Point(0, label2.Height + (int)(this.Height * 0.06));
            panelExternalContact.Location = new Point(0, label2.Height + (int)(this.Height * 0.06));
            panelOccupation.Location = new Point(0, label2.Height + (int)(this.Height * 0.06));
            panelCriminalRecord.Location = new Point(0, label2.Height + (int)(this.Height * 0.06));
            panelReligion.Location = new Point(0, label2.Height + (int)(this.Height * 0.06));
            panelAge.Location = new Point(0, label2.Height + (int)(this.Height * 0.06));
            panelAlcohol.Location = new Point(0, label2.Height + (int)(this.Height * 0.06));
            panelDate.Location = new Point(0, label2.Height + (int)(this.Height * 0.06));

            panelCity.Size = new Size((int)(this.Height * 0.2), (int)(this.Width * 0.3));
            panelDrug.Size = new Size((int)(this.Height * 0.2), (int)(this.Width * 0.3));
            panelExternalContact.Size = new Size((int)(this.Height * 0.2), (int)(this.Width * 0.3));
            panelOccupation.Size = new Size((int)(this.Height * 0.2), (int)(this.Width * 0.3));
            panelCriminalRecord.Size = new Size((int)(this.Height * 0.2), (int)(this.Width * 0.3));
            panelReligion.Size = new Size((int)(this.Height * 0.2), (int)(this.Width * 0.3));
            panelAge.Size = new Size((int)(this.Height * 0.2), (int)(this.Width * 0.3));
            panelAlcohol.Size = new Size((int)(this.Height * 0.2), (int)(this.Width * 0.3));
            panelDate.Size = new Size((int)(this.Height * 0.2), (int)(this.Width * 0.3));

            externalContactCB.Size = new Size((int)(panelAge.Width), (int)(this.Height * 0.5));
            cityCB.Size = new Size((int)(panelAge.Width), (int)(this.Height * 0.5));
            criminalRecordCB.Size = new Size((int)(panelAge.Width), (int)(this.Height * 0.5));
            occupationCB.Size = new Size((int)(panelAge.Width), (int)(this.Height * 0.5));
            religionCB.Size = new Size((int)(panelAge.Width), (int)(this.Height * 0.5));
            drugsCB.Size = new Size((int)(panelAge.Width), (int)(this.Height * 0.5));
            AlcoholCB.Size = new Size((int)(panelAge.Width), (int)(this.Height * 0.5));

            externalContactCB.Location = new Point(panelExternalContact.Width / 2 - externalContactCB.Width / 2, label12.Height);
            cityCB.Location = new Point(panelCity.Width / 2 - cityCB.Width / 2, label12.Height);
            criminalRecordCB.Location = new Point(panelCity.Width / 2 - criminalRecordCB.Width / 2, label12.Height);
            occupationCB.Location = new Point(panelCity.Width / 2 - occupationCB.Width / 2, label12.Height);
            religionCB.Location = new Point(panelCity.Width / 2 - religionCB.Width / 2, label12.Height);
            drugsCB.Location = new Point(panelCity.Width / 2 - drugsCB.Width / 2, label12.Height);
            AlcoholCB.Location = new Point(panelCity.Width / 2 - AlcoholCB.Width / 2, label12.Height);

            label4.Font = new Font("Arial", 12, FontStyle.Bold);
            label5.Font = new Font("Arial", 12, FontStyle.Bold);

            label12.Size = new Size(panelCity.Width, panelCity.Height / 2);
            label12.Location = new Point(panelCity.Width / 2 - label12.Width / 2, 0);
            label12.Font = new Font("Arial", 12, FontStyle.Bold);

            label7.Size = new Size(panelCity.Width, panelCity.Height / 2);
            label7.Location = new Point(panelCity.Width / 2 - label7.Width / 2, 0);
            label7.Font = new Font("Arial", 12, FontStyle.Bold);

            label13.Size = new Size(panelCity.Width, panelCity.Height / 2);
            label13.Location = new Point(panelCity.Width / 2 - label13.Width / 2, 0);
            label13.Font = new Font("Arial", 12, FontStyle.Bold);

            label10.Size = new Size(panelCity.Width, panelCity.Height / 2);
            label10.Location = new Point(panelCity.Width / 2 - label10.Width / 2, 0);
            label10.Font = new Font("Arial", 12, FontStyle.Bold);

            label6.Size = new Size(panelCity.Width, panelCity.Height / 2);
            label6.Location = new Point(panelCity.Width / 2 - label6.Width / 2, 0);
            label6.Font = new Font("Arial", 12, FontStyle.Bold);

            label11.Size = new Size(panelCity.Width, panelCity.Height / 2);
            label11.Location = new Point(panelCity.Width / 2 - label11.Width / 2, 0);
            label11.Font = new Font("Arial", 12, FontStyle.Bold);

            label14.Size = new Size(panelCity.Width, panelCity.Height / 2);
            label14.Location = new Point(panelCity.Width / 2 - label14.Width / 2, 0);
            label14.Font = new Font("Arial", 12, FontStyle.Bold);
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
            if (drug != null)
            {
                listAfterQuery = from person in listAfterQuery
                                 where person.UseDrug == drug
                                 orderby person.firstName ascending
                                 select person;
            }
            if (alcohol != null)
            {
                listAfterQuery = from person in listAfterQuery
                                 where person.UseAlcohol == alcohol
                                 orderby person.firstName ascending
                                 select person;
            }
            if (religion != null)
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
            if (criminalRecord != null)
            {
                listAfterQuery = from person in listAfterQuery
                                 where person.CriminalRecord == criminalRecord
                                 orderby person.firstName ascending
                                 select person;
            }
            if (externalContact != null)
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
            //Clear Query
            listAfterQuery = mainQuery;
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
            //clear Apperance
            dateStart.Refresh();
            dateEnd.Refresh();
            appStartDate = dateStart.Value.Date;
            appEndDate = dateEnd.Value.Date;
            FindAppearance = false;
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
                listAfterQuery = mainQuery;
                string queryToRemove = QueryListBox.SelectedItem.ToString();
                if(queryToRemove.Contains("מין"))
                {
                    genderValue = null;
                    if (Radio_men.Checked)
                        Radio_men.Checked = !Radio_men.Checked;
                    if (Radio_woman.Checked)
                        Radio_woman.Checked = !Radio_woman.Checked;
                    if (Radio_unknowGender.Checked)
                        Radio_unknowGender.Checked = !Radio_unknowGender.Checked;

                }
                else if (queryToRemove.Contains("גיל"))
                {
                    fromAge = 15;
                    ageFromNumeric.Value = 15;
                    toAge = 24;
                    ageToNumeric.Value = 24;
                }
                else if (queryToRemove.Contains("אלכוהול"))
                {
                    AlcoholCB.SelectedIndex = 0;
                    alcohol = null;
                }
                else if (queryToRemove.Contains("סמים"))
                {
                    drugsCB.SelectedIndex = 0;
                    drug = null;
                }
                else if (queryToRemove.Contains("רקע"))
                {
                    religionCB.SelectedIndex = 0;
                    religion = null;
                }
                else if (queryToRemove.Contains("עיסוק"))
                {
                    occupationCB.SelectedIndex = 0;
                    occupation = null;
                }
                else if (queryToRemove.Contains("רישום"))
                {
                    criminalRecordCB.SelectedIndex = 0;
                    criminalRecord = null;
                }
                else if (queryToRemove.Contains("נוכחות"))
                {
                    dateStart.Refresh();
                    dateEnd.Refresh();
                    appStartDate = dateStart.Value.Date;
                    appEndDate = dateEnd.Value.Date;
                    FindAppearance = false;
                }
                else if (queryToRemove.Contains("עיר"))
                {
                    cityCB.SelectedIndex = 0;
                    city = null;
                }
                else if (queryToRemove.Contains("נוסף"))
                {
                    externalContactCB.SelectedIndex = 0;
                    externalContact = null;
                }
                MessageBox.Show(queryToRemove);
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
            string query = chartList.SelectedItem.ToString();
            string graphType = cb_chartType.SelectedItem.ToString();
            string[] titles = new string[0];
            string[] genderArray = { "זכר", "נקבה", "אחר" };
            string[] ageArray = { "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" };
            switch (query)
            {
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
            foreach (var person in listAfterQuery)
            {
                for (int i = 0; i < titles.Length; i++)
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
            QueryGraph g = new QueryGraph(titles, counter, graphType);
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
            if (panelCity.Visible && cityCB.SelectedItem != null)
            {
                city = cityCB.SelectedItem.ToString();
                QueryListBox.Items.Add("לפי עיר: " + city);
            }
            if (panelAlcohol.Visible && AlcoholCB.SelectedItem != null)
            {
                alcohol = AlcoholCB.SelectedItem.ToString();
                QueryListBox.Items.Add("שימוש באלכוהול: " + alcohol);
            }
            if (panelDrug.Visible && drugsCB.SelectedItem != null)
            {
                drug = drugsCB.SelectedItem.ToString();
                QueryListBox.Items.Add("שימוש בסמים: " + drug);
            }
            if (panelReligion.Visible && religionCB.SelectedItem != null)
            {
                religion = religionCB.SelectedItem.ToString();
                QueryListBox.Items.Add("רקע: " + religion);
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

