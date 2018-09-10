using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;

            if (n == 0) return 0;    
            if (n == 1) return 1;    


            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }

            return result;
        }

        


    }

    
}
