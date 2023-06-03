using System;
using System.Collections.Generic;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //---ASSIGNMENT PART 1---//

            // Creates a one-dimensional array of strings
            string[] charNames = { "SpongeBob", "Patrick", "Sandy", "Plankton", "Gary" };
            // This will greet the user and ask to input some text 
            Console.WriteLine("Hello! Type a sentence like this: 'likes to chill in the surf' and see what happens.");
            // This will assign the user input as as string variable named 'userText'
            string userText = Console.ReadLine();

            // This creates a for loop to iterate through each index
            for (int i = 0; i < charNames.Length; i++)
            {
                // This appends whatever text the user inputs to the end of each individual index, but does not print it to the console
                charNames[i] = charNames[i] + " " + userText;
            }
            // This creates a for loop to iterate through each index
            for (int i = 0; i < charNames.Length; i++)
            {
                // This prints each index with the user input appended to the end of it
                Console.WriteLine(charNames[i]);
            }


            //---ASSIGNMENT PART 2---//

            // This would create an infinite loop if the variable 'j' was greater than '0' in the conditional statement
            // I fixed this by changing the '0' to a larger number than '1l
            for (int j = 1; j < 5; j++)
            {
                Console.WriteLine("Leedle Leedle Lee" + j);
            }


            //---ASSIGNMENT PART 3---//

            // This creates a 'while' loop and will continue while the variable a is less than 9
            int a = 1;
            while (a < 9)
            {
                Console.WriteLine("Iteration a: {0}", a);
                // This increments by 1
                a++;
            }

            // This creates a 'while' loop and will continue while the variable a is less than, or equal to 9
            int b = 1;
            while (b <= 9)
            {
                Console.WriteLine("Iteration b: {0}", b);
                b++;
            }


            //---ASSIGNMENT PART 4---//

            // This creates a list named 'colors', with 8 indices
            List<string> colors = new List<string>() { "red", "blue", "green", "yellow", "brown", "black", "pink", "orange", "purple" };
            // This asks the user to input a color
            Console.WriteLine("Enter your favorite color to see if it's listed:");
            // This assings the user input to the variable named 'userGuess'
            string userGuess = Console.ReadLine();
            // This begins a simple if/else loop to check the user input against the list indices
            if (colors.Contains(userGuess))
            {
                // This will print if the user input matches
                Console.WriteLine("Nice! You entered {0}", userGuess);
            }
            else
            {
                // This will print if the user input does not match any index in the list
                Console.WriteLine("Sorry, that color isn't on the list.");
            }


            //---ASSIGNMENT PART 5---//

            // This creates a list named 'heroes', with 8 indices
            List<string> heroes = new List<string>() { "spiderman", "batman", "the hulk", "thor", "the flea", "spawn", "spiderman" };
            // This asks for the user input
            Console.WriteLine("Guess a superhero to see if they made the list and how many times!");
            // This creates a variable from the user input
            string userInput = Console.ReadLine();
            // This creates the boolean variabel 'useGuess' and assigns it the value of 'false
            bool useGuess = false;
            // This 'for' loop iterates through the list
            for (int i = 0; i < heroes.Count; i++)
            {
                // This checks to see if the idex is equal to what the user input
                if (heroes[i] == userInput)
                {
                    // If the user input is found, this will print the input and a statement to thelist
                    Console.WriteLine(userInput + "is on the list!");
                    // This advises that the user's guess was found
                    useGuess = true;
                }
            }
            // This logical operator checks if the user input is found and if not, 
            if (!useGuess)
            {
                // Prints a statement advising that it was not found
                Console.WriteLine(userInput + "is not on the list.");
            }



            //---ASSIGNMENT PART 6---//

            // This creates a list named 'songs'
            List<string> songs = new List<string>() { "Diver", "Lithium", "One Headlight", "1950", "No Diggity", "Lithium", "Work Song" };
            // This loops through each item in the list
            foreach (string song in songs)
            {
                // This creates an integer variable named 'count'
                int count = 0;
                // This is a nested foreach loop that will loop for a second time through the list
                foreach (string s in songs)
                {
                    // This will check if each item is equal to the items from the first 'foreach' loop
                    if (song == s)
                    {
                        // If the item is equal, it will increment the variable 'count' by 1
                        count++;
                    }
                }
                // This is an if/else loop that checks to see if the 's' variable is greater than 1, identifying the duplicated item
                if (count > 1)
                {
                    // This prints a statement to the console next to the duplicated item
                    Console.WriteLine(song + " is duplicated in the list.");
                }
                else
                {
                    // This prints a statement to the console next to the duplciated item
                    Console.WriteLine(song + " is unique to the list.");
                }
            }

            Console.ReadLine();
        }
    }

}
