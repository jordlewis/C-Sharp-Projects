using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {   
            //This prints the string "Anonymous Income Comparison Program"
            Console.WriteLine("Anonymous Income Comparison Program");
            // This prints the string "Person1"
            Console.WriteLine("Person 1");
            // This aks the user for the hourly rate of Person1
            Console.WriteLine("What is the hourly rate for Person 1?");
            string hourlyA = Console.ReadLine();
            Console.WriteLine("Person 1 makes " + hourlyA + " per hour.");
            // This converts the string to a double to be multiplied
            double hourlyRateA = Convert.ToDouble(hourlyA);
            // Asks the user for how many hours Person1 works per week
            Console.WriteLine("How many hours does Person 1 work per week?");
            string hoursA = Console.ReadLine();
            Console.WriteLine("Person 1 works " + hoursA + " per week.");
            // This converts the string to an double to be multiplied
            double hoursWeekA = Convert.ToDouble(hoursA);

            // This prints the string "Person2"
            Console.WriteLine("Person 2");
            // This aks the user for the hourly rate of Person2
            Console.WriteLine("What is the hourly rate for Person 2?");
            string hourlyB = Console.ReadLine();
            Console.WriteLine("Person 2 makes " + hourlyB + " per hour.");
            // This converts the string to a double to be multiplied
            double hourlyRateB = Convert.ToDouble(hourlyB);
            // Asks the user for how many hours Person2 works per week
            Console.WriteLine("How many hours does Person 2 work per week?");
            string hoursB = Console.ReadLine();
            Console.WriteLine("Person 2 works " + hoursB + " per week.");
            // This converts the string to an double to be multiplied
            double hoursWeekB = Convert.ToDouble(hoursB);

            //This calculates Person 1's annual salary and prints the data to the console
            double salaryA = ((hourlyRateA * hoursWeekA) * 52);
            Console.WriteLine("Person 1's annual salary is: ");
            Console.WriteLine(salaryA);
            //This calculates Person 2's annual salary and prints the data to the console
            double salaryB = ((hourlyRateB * hoursWeekB) * 52);
            Console.WriteLine("Person 2's annual salary is: ");
            Console.WriteLine(salaryB);

            // This is an if/else statement to print a true or false statement, based on if Person 1 makes more money than Person 2 annually
            if (salaryA > salaryB)
            {
                Console.WriteLine("Does Person 1 make more money than Person 2? -- True!");
            }
            else
            {
                Console.WriteLine("Does Person 1 make more money than Person 2? -- False!");
            }
            Console.ReadLine();
        }
    }
}
