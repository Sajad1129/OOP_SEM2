using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Admin : Staff
    {
        public int OfficeNo { get; set; }

        public Admin(int officeno, string username) : base(username)
        {
            OfficeNo = officeno;
            Username = username;

        }
    }
}
