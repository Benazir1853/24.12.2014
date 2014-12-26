using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;

        public string FirstName
        {
            set { firstName = value; }
        }

        public string MiddleName
        {
            set { middleName = value; }
        }

        public string LastName
        {
            set { lastName = value; }
        }

        public Person(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName)
        {
            FirstName = firstName;
        }

        public Person()
        {
            
        }

        public string GetFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }

        public string GetReverseName()
        {
            string fullName = GetFullName();
            char[] cArray = fullName.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }



    }
}
