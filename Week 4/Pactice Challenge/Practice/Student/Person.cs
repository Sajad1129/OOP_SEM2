using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Person
    {
        public string FName { get; set; }
        public string SName { get; set; }
        public int YearOfBirth { get; set; }

        public Person(string fName, string sName, int yearOfBirth)
        {
            FName = fName;
            SName = sName;
            YearOfBirth = yearOfBirth;
        }

        static void GetName()
        {

        }

        static void GetAge()
        {

        }
    }

}
