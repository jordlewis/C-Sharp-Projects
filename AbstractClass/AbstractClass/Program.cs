using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // This instantiates an object named 'employee' from the Employee class
            Employee employee = new Employee()
            {
                // The object is instantiated with the firstName property set as 'Sample'
                FirstName = "Sample",
                // The object is instantiated with the lastName property set as 'Student'
                LastName = "Student"
            };

            // This calls the 'SayName' method on the employee object
            employee.SayName();
        }
    }
    
}
