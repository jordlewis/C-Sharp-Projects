using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodDemo
{
    public class MathClass
    {
        public int MyMath(int numbaOne)
        {
            int remainder = 10 - numbaOne;
            return remainder;
        }

        public int MyMath(decimal numbaTwo)
        {
            int product = Convert.ToInt32(numbaTwo * 88);
            return product;
        }
        public int MyMath(string numbaThree)
        {
            // This sets the value of the variable 'sum' to 0
            int sum = 0;
            // This takes the string parameter and converts it to an integer--if possible. 
            if (int.TryParse(numbaThree, out int parse))
            {
                // If the string was converted, it will add 21 to it
                sum = parse + 21;
            }
            // This return the value of 'sum', depending on if the string was able to be parsed.
            return sum;
        }
    }
    
}
