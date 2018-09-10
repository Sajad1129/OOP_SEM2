using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Staff : Person
    {
        public string Username { get; set; }

        public Staff(string username, string fName, string sName, int yearOfBirth) : base(fName, sName, yearOfBirth)
        {
            Username = username;
            FName = fName;
            SName = sName;
            YearOfBirth = yearOfBirth;

            Console.ReadLine();
        }
    
    }
}
