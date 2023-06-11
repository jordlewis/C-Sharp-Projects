using System;
using static ParsingEnums.Week;

namespace ParsingEnums
{
    class Program
    {
        public static void Main(string[] args)
        {
            // This begins the try/catch block of code to check user input agains the enum
            try
            {
                // This prompts the user to enter the current day of the week into the console
                Console.WriteLine("Please enter the current day of the week:");
                //  This assigns the user input to a variable named 'userInput'
                string userInput = Console.ReadLine();

                // This will parse the user inpust and then cast it as an instance of the enum if it matches
                Days day = (Days)Enum.Parse(typeof(Days), userInput);
                // This writes a message to the console if the user input was successfully converted to a value in the enum Days
                Console.WriteLine("Thanks, you entered: {0}", day);

            }
            // This will throw an exception if the cast fails
            catch (Exception)
            {
                // This exceptions will write a statement to the console that
                // alerts the user that the input was off
                Console.WriteLine("Please enter an actual day of the week.");
            
            }

            Console.ReadLine();
        }
    }
}