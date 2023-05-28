using System;
using System.Text; // namespace that allows the utilization of StringBuilder

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates the first string variable 'fName'
            string fName = "Anakin ";
            // Creates the second string variable 'lName'
            string lName = "Skywalker ";
            // Creates the backend of the sentence
            string opin = "is the greatest character ever created.";
            // This will concatenate all 3 string variables together, forming a sentence
            string statement = fName + lName + opin;
            // Prints the variable 'statement' aka the sentence concatenated together
            Console.WriteLine(statement);

            // Creating a simple string variable
            string preach = "I know that's right!";
            // Converting the string to all uppercase 
            Console.WriteLine(preach.ToUpper());

            // Creates a StringBuilder named 'myBuilder', initializing with 'Hey!' and a character length of 45
            StringBuilder myBuilder = new StringBuilder("Hey!", 45);
            // This adds 'what's good' to the string on a new line
            myBuilder.Append("\n What's good?");
            // This adds 'Mother Earth is.' to the string on a new line
            myBuilder.Append("\n Mother Earth is.");
            // This prints the StringBuilder 'myBuilder' to the console
            Console.WriteLine(myBuilder);
            Console.ReadLine();

        
        }
    }
}
