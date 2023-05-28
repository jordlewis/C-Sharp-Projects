using System;
using System.Collections.Generic; // This is a namespace that will assist in creating the string list below, with any data type

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing a welcome statement to the console user and provided the numerical range for the user to choose from
            Console.WriteLine("Welcome to the Array Game! \n Please choose an index between 0 and 4 to see what Toy Story character you get!");
            // Creating a new one-dimensional string array for the user to select an index from, and assigning a string at each index
            string[] stringArray = new string[] { "Woody", "The Green Aliens", "Jesse", "Bullseye", "Buzz Lightyear" };
            // Converts the user input to an integer
            int userGuess1 = Convert.ToInt32(Console.ReadLine());

            // This is a simple if/else statement to either print the string to the corresponding index the user chose
            if (userGuess1 < 5)
            {
                // This prints the chosen index to the console from the string array
                Console.WriteLine(stringArray[userGuess1]);
            }
            else
            {
                // This simply advises the user that they did not select an index within the given range
                Console.WriteLine("Sorry, the index you selected does not exist.");
            }

            // Printing a new statement to the console for the integer array
            Console.WriteLine("\n Now pick another index, between 0 and 7 to find out your lucky number!");
            // This creates an integer array and assigns an integer at one of each of the 7 indices
            int[] intArray = { 47, 1, 999, 65, 8, 21, 69, 12 };
            // This will convert the user input from a string to an integer
            int userGuess2 = Convert.ToInt32(Console.ReadLine());

            // Another simeple if/else statement to print the user-picked index to the console, or a message stating the value chosen does not exist.
            if(userGuess2 < 8)
            {
                Console.WriteLine(intArray[userGuess2]);
                
            }
            else
            {
                Console.WriteLine("Sorry, the index you selected does not exist.");
            }

            // Prints a new statement to the console for the string list
            Console.WriteLine("\n Pick a final index between 0 and 5 to draw a surprise character!");
            // Creating a list with the string data type
            List<string> stringList = new List<string>();
            // This adds the first string to the list
            stringList.Add("Sully");
            // This adds the second string to the list, and so on
            stringList.Add("Mike");
            stringList.Add("Boo");
            stringList.Add("Celia");
            stringList.Add("Roz");
            stringList.Add("Randall");

            // This converts the user input to a an integer
            int userGuess3 = Convert.ToInt32(Console.ReadLine());

            if (userGuess3 < 6)
            {
                Console.WriteLine(stringList[userGuess3]);
                
            }
            else
            {
                Console.WriteLine("Sorry, the index you selected does not exist");
            }
            
            Console.ReadLine();
        }
    }
}
