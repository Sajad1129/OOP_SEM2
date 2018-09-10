using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIV_UnitTesting_Exercise.test
{

    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test1()
        {
            Assert.That(true);
        }


        /// <summary>
        /// Checks if num is a Fibonacci Number
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool FibCheck(int num)
        {
            int ans = 0;
            int a = 1, b = 1;

            while (ans < num)
            {
                ans = a + b;
                if (ans == num)
                {
                    return true;
                }

                a = b;
                b = ans;
            }
            return false;
        }
    }
}
