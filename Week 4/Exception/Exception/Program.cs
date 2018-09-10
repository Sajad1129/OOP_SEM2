using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Except
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int n, sum = 0, m;
                Console.Write("Enter a number: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    throw new ZeroException();
                }

                

                if (n > 15)
                {
                    throw new fifthException();
                }
                while (n > 0)
                {
                    m = n % 10;
                    sum = sum + m;
                    n = n / 10;
                }


                Console.Write("Sum is " + sum);


            }

            catch (FormatException excep)
            {
                Console.WriteLine(excep.Message);
            }

            catch (ZeroException zero)
            {
                Console.WriteLine(zero.Message);

            }

            catch (fifthException fifth)
            {
                Console.WriteLine(fifth.Message);
            }

            Console.ReadKey();

        }

        
    }
    
}

public class FormatException : Exception
{
    public FormatException() : base("Input should be Integer " + DateTime.Now)
    {

    }
}

public class ZeroException : Exception
{
    public ZeroException() : base("Input should be more than Zero " + DateTime.Now)
    {

    }
}

public class fifthException : Exception
{
    public fifthException() : base("number is greater than 15 " + DateTime.Now)
    {

    }
}