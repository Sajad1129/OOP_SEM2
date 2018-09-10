using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student : Person
    {
        public int Id { get; set; }

        public Student(int id, string fName, string sName, int yearOfBirth): base(fName, sName, yearOfBirth)
        {
            Id = id;
            FName = fName;
            SName = sName;
            YearOfBirth = yearOfBirth;

            Console.ReadLine();
        }
    }
}
