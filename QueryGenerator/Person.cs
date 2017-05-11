using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryGenerator
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public int yearOfBirth { get; set; }
        public string city { get; set; }
        public string meetDate { get; set; }
        public string CurrentOccupation { get; set; }
        public string ExternalContact { get; set; }
        public string UseAlcohol { get; set; }
        public string UseDrug { get; set; }
        public string Religion { get; set; }
        public string CriminalRecord { get; set; }
        Boolean[] Presence = new Boolean[366];



        public Person(int yearofbirth, string firstname, string lastname, string gender, string city,
         string meetDate, string currentOccupation, string externalContact, string useAlcohol, string useDrug,
         string religion, string criminalRecord, Boolean[] presence)
        {
            yearOfBirth = yearofbirth;
            age = DateTime.Today.Year - yearofbirth;
            firstName = firstname;
            lastName = lastname;
            this.city = city;
            this.gender = gender;
            if (meetDate != "")
                this.meetDate = meetDate.Substring(0, 8);
            CurrentOccupation = currentOccupation;
            ExternalContact = externalContact;
            UseAlcohol = useAlcohol;
            UseDrug = useDrug;
            Religion = religion;
            CriminalRecord = criminalRecord;
            Presence = presence;
        }
    }
}