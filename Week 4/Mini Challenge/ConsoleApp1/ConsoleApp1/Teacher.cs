using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Teacher : Staff
    {
        public string Expertise { get; set; }

        public Teacher(string expertise, string username) : base(username)
        {
            Expertise = expertise;
            Username = username;

        }
    }
}
