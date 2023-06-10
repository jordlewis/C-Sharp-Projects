using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // This creates a class called 'Employee' that inherits from the abstract class 'Person'
    public class Employee : Person
    {
        // This implements the 'SayName' function that is inherited from the Person class
        public override void SayName()
        {
            // This prints the full name to the console
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }
    }
}
