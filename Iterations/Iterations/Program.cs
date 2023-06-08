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
            // This creates a boolean variable called 'gotcha' to check against user input
            bool gotcha = false;
            // This begins a simple for loop to check the user input against the list indices
            for (int c = 0; c < colors.Count; c++)
            {
                if (colors[c].Contains(userGuess))
                {
                    // This will print to the console if the user input is found on the list, and provide the input index
                    Console.WriteLine("Index of {0} is {1}", colors[c], c);
                    // This states that if the user input is found, the variable 'gotcha' indicates that it's true/'found'
                    gotcha = true;
                    break;
                }
            }
            // This logical operator checks if the user input is found and if not 
            if (!gotcha)
            {
                Console.WriteLine("{0} is not on the list, sorry.", userGuess);
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
            for (int d = 0; d < heroes.Count; d++)
            {
                // This checks to see if the idex is equal to what the user input
                if (heroes[d] == userInput)
                {
                    // If the user input is found, this will print the input and a statement to the console with the corresponding index
                    Console.WriteLine(userInput + " is on the list! Found at {0}", d);
                    // This advises that the user's guess was found
                    useGuess = true;
                }
            }
            // This logical operator checks if the user input is found and if not, 
            if (!useGuess)
            {
                // Prints a statement advising that it was not found
                Console.WriteLine(userInput + " is not on the list.");
            }



            //---ASSIGNMENT PART 6---//

            // This creates a list named 'songs'
            List<string> songs = new List<string>() { "Diver", "Lithium", "One Headlight", "1950", "No Diggity", "Lithium", "Work Song" };
            // This creates a for loop to iterate through each index
            for (int e = 0; e < songs.Count; e++)
            {
                // during the for loop, each item will have the boolean value of 'false' attached to it
                bool dupe = false;
                // This creates a 'foreach' loop to evaluate each index
                foreach (string song in songs)
                {
                    // checks to see if the index is the same as the index in the outer 'for' loop, and if so prints the respective message    
                    if(song == songs[e] && dupe)
                    {
                        Console.WriteLine("This item is a duplicate --- {0}", song);
                        // This will end the nested loop to continue on
                        break;
                    }
                    else if (song == songs[e])
                    {
                        Console.WriteLine("This item is unique to the list --- {0}.", song);
                        // This assigns the boolean value of 'true' if the index hasn't been duplicated in the list
                        dupe = true;
                    }
                }
            }

            Console.ReadLine();
        }
    }

}
