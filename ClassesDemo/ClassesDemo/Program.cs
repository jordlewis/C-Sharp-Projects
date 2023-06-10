using System;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // This instantiates the class 'Leedle' as 'littleClass'
            Leedle littleClass = new Leedle();
            // This prompts the user to enter a number to passed along to the methods
            Console.WriteLine("Howdy! Please enter a number to see what happens: ");
            // This converts the user input ot an integer named 'userNumber'
            int usernumber = Convert.ToInt32(Console.ReadLine());
            // This calls the first method 'oneMethod' and passes the userinput to be evaluated
            littleClass.oneMethod(usernumber);

            // This creates the integer variable 'output'
            int output;
            // This calls the overloaded method and passes two parameters to it
            littleClass.oneMethod(usernumber, out output);
            // This prints the value of the variable 'output' to the console
            Console.WriteLine("{0} multiplied by five is {1}", usernumber, output);

            // This calls the static class and method without instanstiation 
            Stat.writeConsole();

            // This instantiates the Employee object
            Employee employee = new Employee()
            {
                // This sets the employee object FirstName as 'Sample'
                FirstName = "Sample",
                // This sets the employee object LastNAme as 'Student'
                LastName = "Student",
            };

            // This calls the superclass method 'SayName()' on the employee object
            // which prints the verbiage 'Full Name: Sample Student' to the console
            employee.SayName();

            Console.ReadLine();
        }
    }
}
