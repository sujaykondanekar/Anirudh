using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class Calc
    {
        /// <summary>
        /// Method to add two numbers.
        /// </summary>
        /// <param name="a">1st parameter for addition</param>
        /// <param name="b">2nd parameter for addition</param>
        /// <returns>Sum of A+B</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Diff(int a, int b)
        {
            return b - a;
        }

        public int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                return -1;
            }
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}