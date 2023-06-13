using System;



namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // This prints the current date and time to the console 
            Console.WriteLine("The time is currently: \n" + DateTime.Now);
            // This takes the current time and assigns it into the variable 'currentTime'
            DateTime currentTime = DateTime.Now;
            // This asks the user to enter a number 
            Console.Write("Please choose a a number to learn something interesting:  ");
            // This takes the user input, parses through it and assigns it as an integer variable
            int user = Convert.ToInt32(Console.ReadLine());
            // This will add the user input to current time
            DateTime interestingFact = currentTime.AddHours(user);
            // This will print the user input added to the current time, as a future date and time
            Console.WriteLine("{0} hours from now is {1}", user, interestingFact);
        }
    }
}
