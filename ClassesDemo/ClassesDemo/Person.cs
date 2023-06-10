using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesDemo
{
    //---- INHERITANCE ----
    // This creates the public class 'Person'
    public class Person
    {
        // This sets the first string property 'FirstName'
        public string FirstName { get; set; }
        // This sets the second string property 'LastName'
        public string LastName { get; set; }

        // This is a void method called 'SayName'
        public void SayName()
        {
            // This will print a statement to the console with the full name
            Console.WriteLine($"Name: {FirstName} {LastName}");
        
        }
    }
}
