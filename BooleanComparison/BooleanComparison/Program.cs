using System;

namespace BooleanComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a basic 'while' statement
            // This prints a welcome statement to the user
            Console.WriteLine("Guess my favorite number!");
            // This assignes the user iput as a integer variable named 'userNum'
            int userNum = Convert.ToInt32(Console.ReadLine());
            // This is a comparison expression to return 'true' or 'false', depending if the user guessess the correct number
            bool num = userNum == 21;

            // This is the 'while' statement
            // This states that while the user's input evaluates to false, it will run through the 'while' loop
            while (!num)
            {
                switch (userNum)
                {
                    // If the user enters the integer 5, then the 5 case will execute
                    case 5:
                        // This prints the the case 5 statement and provides a hint for the next user guess
                        Console.WriteLine("You guessed 5! That's too low!");
                        // This statement prompts the user to guess again
                        Console.WriteLine("Try again!");
                        // This convertes the user input to an integer to be evaluated
                        userNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5974136:
                        // This prints the the case 5974136 statement and provides a hint for the next user guess
                        Console.WriteLine("You guessed 5974136! That's WAY too high!");
                        Console.WriteLine("Try again!");
                        userNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 25:
                        Console.WriteLine("You guess 25! That's a bit too high, but you're so close!");
                        Console.WriteLine("Try again!");
                        userNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 21:
                        Console.WriteLine("You that right! 21 is my favorite number!");
                        num = true;
                        break;
                    case 18:
                        Console.WriteLine("Oh man, you're so close! A bit higher..");
                        Console.WriteLine("Try again!");
                        userNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        // This is the default response, if the user input does not macth with any of the above cases
                        Console.WriteLine("That number isn't close enough for a hint...");
                        Console.WriteLine("Try again!");
                        userNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            // Pivoting to a 'do while' statement style game
            Console.WriteLine("Now let's play a new game!");
            Console.WriteLine("Let's begin!");
                                  
            
            // This is a 'do while' statement
            // This prints a welcome statement to the user
            Console.WriteLine("Guess my favorite fruit!");
            // This assignes the user iput as a string variable named 'userGuess'
            string userGuess = Console.ReadLine();
            // This is a comparison expression to return 'true' or 'false', depending if the user guessess the correct fruit
            bool guess = userGuess == "strawberry";
            // This will create a loop while the user's input evaluates to 'false'
            do
            {
                // This statement allows different blocks of code to run, dependent on the user's input
                switch (userGuess)
                {
                    // If the user enters the string 'strawberry', then the strawberry case will execute
                    case "strawberry":
                        Console.WriteLine("You guessed it! It's a strawberry! Hooray!");
                        // This evaluates the user's guess as 'true'
                        guess = true;
                        break;
                    // If the user enters 'apple', this block of code will execute and advise to try again
                    case "apple":
                        Console.WriteLine("You guessed apple. Not quite!");
                        Console.WriteLine("Guess again!");
                        // This assigns the user input to the variable 'userGuess' to be evaluated as 'true' or 'false' against the assigned string 'strawberry'
                        userGuess = Console.ReadLine();
                        break;
                    case "banana":
                        Console.WriteLine("You guessed banana. Not quite!");
                        Console.WriteLine("Guess again!");
                        userGuess = Console.ReadLine();
                        break;
                    // This is the default response, if the user input does not macth with any of the above cases
                    default:
                        Console.WriteLine("Nope...");
                        Console.WriteLine("Guess again!");
                        userGuess = Console.ReadLine();
                        break;
                }
            }
            // This is the 'while' condition, running the loop while the user's input evaluates to 'false'
            while (!guess);

                Console.Read();

            }

        }

    }