using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    // This creates an abstract class called 'Person' that cannot be instatiated
    public abstract class Person
    {
        // This creates the first property 'firstName'
        public string FirstName { get; set; }
        // This creates the second property 'lastName'
        public string LastName { get; set; }

        // This is an abstract method that MUST be implementd by the class that inherits it
        public abstract void SayName();
    }
}
