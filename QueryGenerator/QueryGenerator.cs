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
        private IEnumerable<Person> mainQuery;
        private IEnumerable<Person> listAfterQuery;

        //==================Queries Variables=========================
        private String genderValue=null;
        private int fromAge = 0, toAge = 0;
        private String city = null;


        public QueryGenerator(List<Person> listOfPepoles, HashSet<string> hashSetOfcities )
        {
            listOPepoles = listOfPepoles;
            hashSetOfCities = hashSetOfcities;
            mainQuery = from p in listOPepoles select p;
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
            if(genderValue!=null)
            {
                listAfterQuery = from person in mainQuery
                                 where person.gender == genderValue
                                 orderby person.firstName ascending
                                 select person;
            }
            if(fromAge!=0 && toAge!=0)
            {
                listAfterQuery = from person in mainQuery
                                 where person.age >= fromAge && person.age<=toAge
                                 orderby person.firstName ascending
                                 select person;
            }
            if(city!=null)
            {
                listAfterQuery = from person in mainQuery
                                 where person.city == city
                                 orderby person.firstName ascending
                                 select person;
            }
            
                int sum = 0;
                StringBuilder str = new StringBuilder();
                foreach (Person p in listAfterQuery)
                {
                    str.Append(p.firstName+" "+p.lastName+ " " +p.age + " " + p.city +  "\r\n");
                    sum++;
                }
                listBox.Text="סה\"כ: " + sum + ":\r\n" + str.ToString();
                //MessageBox.Show("Total of: "+ sum +":"+ str.ToString());
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
                queryList.AppendText(" :לפי מין" + genderValue + "\r\n");
            }
            if (panelAge.Visible)
            {
                fromAge = (int)ageFromNumeric.Value;
                toAge = (int)ageToNumeric.Value;
                queryList.AppendText("טווח גילאים: " + fromAge + " - " + toAge + "\r\n");
            }
            if(panelCity.Visible)
            {
                city = cityCB.SelectedItem.ToString();
                queryList.AppendText("לפי עיר: " + city + "\r\n");
            }
                
            }
        }       
    }

