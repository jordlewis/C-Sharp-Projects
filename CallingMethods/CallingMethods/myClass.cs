using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    // This creates a public class
    public class MyClass
    {
        // This is the first method that will take the user input and multiply it by 10
        public int timesTen(int userInput)
        {
            int product = userInput * 10;
            return product;
        }
        // This is the second method that will take the user input and divide it in half
        public int inHalf(int userInput)
        {
            int quotient = userInput / 2;
            return quotient;
        }
        // This is the third method that will take the user input and add 3521479 to it
        public int highNum(int userInput)
        {
            int sum = userInput + 3521479;
            return sum;
        }
    }
}
