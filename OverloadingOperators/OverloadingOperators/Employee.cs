using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadingOperators
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Id { get; set; }

        // This overloads the comparision operator '==' to define how the two instantiated objects of Employee should be compared
        // This takes two arguments to compare and evaluates both by the object's id number
        public static bool operator ==(Employee employeeA, Employee employeeB)
        {
            // This compares the object by their employee id numbers and returns a boolean value to the console
            return employeeA.Id == employeeB.Id;
        }

        // Overloading the '!=' operator as they have to be overloaded in pairs
        public static bool operator !=(Employee employeeA, Employee employeeB)
        {
            // This returns the opposite of the '==' operator and returns the value to the console
            return !(employeeA == employeeB);
        }
    }
}
    