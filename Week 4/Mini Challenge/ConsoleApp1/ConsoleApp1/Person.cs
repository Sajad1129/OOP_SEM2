using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Person
    {
        public string FName;
        public string SName;
        public int YearOfBirth;
        

        public void GetName()
        {
            Console.WriteLine("Enter First Name");
            FName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            SName = Console.ReadLine();




        }

        public void GetAge()
        {
            Console.WriteLine("Enter Your Age");
            YearOfBirth = int.Parse(Console.ReadLine());
            
        }

        public Person(string fName, string sName, int yearOfBirth)
        {
            FName = fName;
            SName = sName;
            YearOfBirth = yearOfBirth;
        }

        public class Student : Person
        {
            public int Id;

            public void GetInfo()
            {
                Console.WriteLine("First Name" + {FName} )

            }

        }

        public class Staff : Person
        {
            public string Username;
        }



        public class Teacher : Staff
        {
            public string Expertise;
        }


        public class Admin : Staff
        {
            public int OfficeNo;
        }






       
    }
}
