using System;
using System.Collections.Generic;
using System.Text;

namespace MoreMethods
{
    // This creates the public class 'ClassA'
    public class ClassA
    {
        //----THIS IS 1ST SUBMISSION----

        // This takes the user input and an integers, adds them together and returns the sum
        // This takese two arguments, with the 'mine' being an optional arugment, set at '0'
        public int MethodA(int number1, int mine = 0)
        {
            int sum = number1 + mine;
            return sum;
        }
    }

    // This creates the public class 'ClassB'
    public class ClassB
    {
        // This creates a method that takes two integer arguments
        public void MethodB(int number3, int number4)
        {
            // This mutliplies the variable 'number3' by 100
            int result = number3 * 100;
            // This displays the second variable, 'number4' to the screen
            Console.WriteLine(number4);
        }

    }
}