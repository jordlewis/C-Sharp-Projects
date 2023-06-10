using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesDemo
{
    //---- INHERITANCE ----
    // This creates the public class 'Employee', that inherits from the class 'Person'
    public class Employee : Person
    {
        // This adds the property 'Id' to the employee objects created
        public int Id { get; set; }
    }
}
