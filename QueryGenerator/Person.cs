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
        public string NumOfInstitutions { get; set; }
        public string PostitutionSequence { get; set; }

        public string ShelterSequence { get; set; }

        public Dictionary<DateTime, bool> Presence { get; set; }


    public Person(int yearofbirth, string firstname, string lastname, string gender, string city,
         string meetDate, string currentOccupation, string externalContact, string useAlcohol, string useDrug,
         string religion, string criminalRecord,string numofinstitutions,string postitutionsequence,
         string sheltersequence, Dictionary<DateTime,bool> presence)
        {
            yearOfBirth = yearofbirth;
            if (yearofbirth != 0) { age = DateTime.Today.Year - yearofbirth; } else { age = 0; }
            firstName = firstname;
            lastName = lastname;
            this.city = city;
            this.gender = gender;
            if (meetDate != "")
            {
                this.meetDate = meetDate.Substring(0, 8);
            }
            CurrentOccupation = currentOccupation;
            ExternalContact = externalContact;
            UseAlcohol = useAlcohol;
            UseDrug = useDrug;
            Religion = religion;
            CriminalRecord = criminalRecord;
            Presence = presence;
            NumOfInstitutions = numofinstitutions;
            PostitutionSequence = postitutionsequence;
            ShelterSequence = sheltersequence;
        }
        public int numOfArrivalesInRange( DateTime startDate, DateTime endDate)
        {
            int count = 0;
            foreach (DateTime day in EachDay(startDate, endDate))
            {
                if (Presence[day] == true)
                {
                    count++;
                }
            }
            return count;
        }
        private static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
            {
                yield return day;
            }
        }
    }
}