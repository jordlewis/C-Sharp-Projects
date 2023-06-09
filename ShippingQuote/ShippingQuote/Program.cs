﻿using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            // This prints a welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            // This prompts the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");
            // This converts the user's input to an integer
            int weight = Convert.ToInt32(Console.ReadLine());

            // This is the if/esle statement to advise the user that their package does not meet requirements, or provides the actual quote tailored to the user's input
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                // This prompts the user to enter the package width
                Console.WriteLine("Please enter the the package width:");
                // This converts the user's input to an integer
                int width = Convert.ToInt32(Console.ReadLine());

                // This prompts the user to enter the package height
                Console.WriteLine("Please enter the package height:");
                // This converts the user's input to an integer
                int height = Convert.ToInt32(Console.ReadLine());

                // This prompts the user to enter the package length
                Console.WriteLine("Please enter the package length");
                // This converts the user's input to an integer
                int length = Convert.ToInt32(Console.ReadLine());

                int dimensions = (length + width + height);

                if (dimensions > 50) {

                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }

                else {
                    // This creates the user's total price by multiplying the height x length x width, then dividing by weight
                    int price = (((length * width * height) * weight) / 100) ;

                    // This creates a string named 'quote' that displays a message and the total price of the shipping quote, formatted for currency
                    string quote = ("Your estimated total for shipping this package is: " + price.ToString("C"));

                    Console.WriteLine(quote);
                }
            }

            Console.ReadLine();



        }
    }
}
