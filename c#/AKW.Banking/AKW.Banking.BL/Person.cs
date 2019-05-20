using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKW.Banking.BL
{
    public class Person
    {
        private string ssn;

        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        private string firstname;

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        private string lastname;

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private DateTime birthdate;

        public DateTime BirthDate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        private string fullname;

        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }



       
    }
}
