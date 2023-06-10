using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // This creates a class called 'Employee' that inherits from the abstract class 'Person'
    public class Employee : Person, IQuittable
    {
        // This implements the 'SayName' function that is inherited from the Person class
        public override void SayName()
        {
            // This prints the full name to the console
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }

        // This implements the Quit() method that was defined in the IQuittable interface
        public void Quit()
        {
            // This prints a statement to the console
            Console.WriteLine("And the itsy-bitsy spider slid down the water spout as if it were a water slide in a water park.");
        }
    }
}
