using System;
using System.Collections.Generic;
using System.Text;

namespace MoreMethods
{
    // This creates the public class 'ClassA'
    public class ClassA
    {
        // This takes the user input and an integers, adds them together and returns the sum
        // This takese two arguments, with the 'mine' being an optional arugment, set at '0'
        public int MethodA(int number1, int mine = 0)
        {
            int sum = number1 + mine;
            return sum;
        }
     }   
}
