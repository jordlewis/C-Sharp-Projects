using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesDemo
{
    class Leedle
    {
        // This is the first method that will divide an integer by 2 and write the result to the console
        public void oneMethod(int usernumber)
        {
            // This divides the number in half
            int endgame = usernumber / 2;
            // This prints the result to the console with a statement
            Console.WriteLine("{0} cut in half is: {1}", usernumber, endgame);
        }

        // This method is overloaded; Same name, but different parameters
        public void oneMethod(int usernumber, out int endgame)
        {
            // This method multiplies the variable 'endgame' by 5
            endgame = usernumber * 5;
        }
    }
}