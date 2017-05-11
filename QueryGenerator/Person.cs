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

        public Person(int yearofbirth, string firstname, string lastname, string gender, string city,string meetDate)
        {
            yearOfBirth = yearofbirth;
            age = DateTime.Today.Year - yearofbirth;
            firstName = firstname;
            lastName = lastname;
            this.city = city;
            this.gender = gender;
            if(meetDate!="")
                this.meetDate = meetDate.Substring(0,8);
        }
    }
}
