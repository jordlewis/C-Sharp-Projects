using System;

namespace InsuranceQualifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // This writes a welcome statement to the console
            Console.WriteLine("Welcome to the Insurance Qualifier!");


            // This asks the user to input their current age
            Console.WriteLine("What is your current age?");
            // This will retrieve the user input as a string
            string userAge = Console.ReadLine();
            // This will convert 'userAge' to an integer
            int age = Convert.ToInt32(userAge);

            // This asks the user if they have ever had a DUI
            Console.WriteLine("Have you ever had a DUI? Please anser 'True' or 'False'");
            // This will retrive the user input as a string
            string userAnsA = Console.ReadLine();
            // This will convert 'userAnsA'to boolean logic
            bool ansDui = Convert.ToBoolean(userAnsA);

            // This asks the user how many speeding tickets they have
            Console.WriteLine("How many speeding tickets have you received?");
            // This will retrieve the user input as a string
            string userAnsB = Console.ReadLine();
            // This converts 'userAnsB' to an integer
            int tickets = Convert.ToInt32(userAnsB);

            // This is an if/else statement to qualify the user based off of their input, using boolean logic and pre-set busuiness rules
            // The if statement checks that the user is over 15 years of age, they have never had a DUI and have accumulated less than 3 speeding tickets
            if (age > 15 && ansDui == false && tickets < 3)
            {
                Console.WriteLine("Congratulations! You have qualified for insurance.");
            }
            // If the user input does not meet the pre-set criteria, the else statement will print the user does not qualify
            else
            {
                Console.WriteLine("I'm sorry, you do not qualify for insurance at this time.");
            }

            Console.ReadLine();

        }
    }
}
