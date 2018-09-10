using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student : Person
    {
        public int Id { get; set; }

        public Student(int id, string fName, string sName, int yearOfBirth)
        {
            Id = id;
        }
    }
}
