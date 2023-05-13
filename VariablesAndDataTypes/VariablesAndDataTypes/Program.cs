using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            Console.WriteLine("Your favorite number is: " + favoriteNumber);
            Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.30203092;

            float secondsLeft = 3.5f;

            short temperatureOnMars = -341;

            string myName = "jordyn";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();

            Console.WriteLine(questionMark);
            Console.ReadLine();

        }
    }
}
