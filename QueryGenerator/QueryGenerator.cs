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


        public QueryGenerator(List<Person> listOfPepoles, HashSet<string> hashSetOfcities, HashSet<string> hashSetCurrentoccupation, HashSet<string> hashSetExternalcontact
            , HashSet<string> hashSetUsealcohol, HashSet<string> hashSetUsedrug, HashSet<string> hashSetreligion,HashSet<string> hashSetlistOfCriminalrecord)
        {
            try
            {
                panelResults.Width = (int)(Console.WindowWidth * 0.7);
                panelResults.Height = (int)(Console.WindowHeight * 0.9);
                QueryBox.Width = (int)(Console.WindowWidth * 0.3);
                QueryBox.Height = (int)(Console.WindowHeight * 0.4);
                QueryListBox.Width = (int)(Console.WindowWidth * 0.3);
                QueryListBox.Height = (int)(Console.WindowHeight * 0.4);
            }
            catch (Exception e) { }
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

        private void QueryGenerator_Load(object sender, EventArgs e)
        {

        }

        private void cb_gender_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_gender.Checked)
            {
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
                disableVisabilityPanels();
                panelAge.Visible = true;
            }
            else
            {
                panelAge.Visible = false;
            }

        }

        private void disableVisabilityPanels()
        {
            panelCity.Visible = false;
            panelGender.Visible = false;
            panelAge.Visible = false;
            panelAlcohol.Visible = false;

        }

        private void cb_city_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_city.Checked)
            {
                disableVisabilityPanels();
                cityCB.Items.AddRange(hashSetOfCities.ToArray());
                panelCity.Visible = true;
            }
            else
            {
                panelCity.Visible = false;
            }
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
            city = null;
            cityCB.SelectedIndex = 0;
            //ClearQueryPanel
            listAfterQuery = mainQuery;
            queryList.Text = "";
            //ClearTable
            dataListGrid.DataSource = null;
            if (cb_age.Checked)
                cb_age.Checked = !cb_age.Checked;
            if (cb_city.Checked)
                cb_city.Checked = !cb_city.Checked;
            if (cb_gender.Checked)
                cb_gender.Checked = !cb_gender.Checked;
        }


        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (queryList.SelectedIndex >= 0)
            {
                queryList.Items.RemoveAt(queryList.SelectedIndex);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_alcohol.Checked)
            {
                disableVisabilityPanels();
                AlcoholCB.Items.AddRange(hashSetUseAlcohol.ToArray());
                panelAlcohol.Visible = true;
            }
            else
            {
                panelAlcohol.Visible = false;
            }
        }

        private void panel_alcohol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelQuery_Paint(object sender, PaintEventArgs e)
        {

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

                queryList.Items.Add("לפי מין: " + genderValue);
            }
            if (panelAge.Visible)
            {
                fromAge = (int) ageFromNumeric.Value;
                toAge = (int) ageToNumeric.Value;
                queryList.Items.Add("טווח גילאים: " + fromAge + " - " + toAge);
            }
            if (panelCity.Visible)
            {
                city = cityCB.SelectedItem.ToString();
                queryList.Items.Add("לפי עיר: " + city);
            }

        }
    }
}

