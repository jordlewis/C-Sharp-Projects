using System;

namespace OverloadingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // This instantiates the first Employee object,'firstEmployee', and fills in the respective information
            Employee firstEmployee = new Employee { Id = 89, FirstName = "John", LastName = "Doe" };
            // This instantiates the second Employee object,'firstEmployee', and fills in the respective information
            Employee secondEmployee = new Employee { Id = 64, FirstName = "Jane", LastName = "Doe" };
            // This uses the overloaded '==' operator to compare the two objects
            Console.WriteLine(firstEmployee == secondEmployee);
        }
    } 
}
