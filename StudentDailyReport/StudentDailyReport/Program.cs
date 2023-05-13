using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // This prints 'The Tech Academy' to the console
            Console.WriteLine("The Tech Academy");
            // This prints 'Student Daily Report' to the console
            Console.WriteLine("Student Daily Report");

            // This asks the user what their name is
            Console.WriteLine("what is your name?");
            // This assigns the user input as the string variable 'userName'
            string userName = Console.ReadLine();

            // This asks the user what course their on
            Console.WriteLine("What course are you on?");
            // This assigns the user input as the string variable 'courseName'
            string courseName = Console.ReadLine();

            // This asks the user what page number they are on
            Console.WriteLine("What page number are you on?");
            // This assigns the user input to the string variable 'pageNum'
            string pageNum = Console.ReadLine();
            // This converts the string variable to an integer variable
            int pageNumber = Convert.ToInt32(pageNum);

            // This asks the user if they need help with anything, using boolean logic
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            // This assigns the user input to the string value variabe 'userAns'
            string userAns = Console.ReadLine();
            // This coverts the string variable to a boolean variable
            bool userAnswer = Convert.ToBoolean(userAns);

            // This asks the user if they have any positive experiences they'd like to share
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            // This assigns the user input to the string variable 'posExp'
            string posExp = Console.ReadLine();

            // This asks the user if they have any other feedback they'd like to provide
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            // This assigns the user input to the string variable 'feedback'
            string feedback = Console.ReadLine();

            // This asks the user how many hours they've studied today
            Console.WriteLine("How many hours did you study today?");
            // This assigns the user input to the string variable 'hours'
            string hours = Console.ReadLine();
            // This converts the string variable to a decimal variable named 'hoursToday'
            decimal hoursToday = Convert.ToDecimal(hours);

            // This will print "Thank you for your answers. An Instructor will respond to this shortly. Have a great day!”
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");



        }
    }
}
