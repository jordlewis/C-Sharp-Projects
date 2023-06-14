using System;

namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)

        {
            const string species = "human";

            // This passes arguments to the chained constructors
            Character char1 = new Character("Jordyn", "Lewis", 30);
            Character char2 = new Character("Mel", "W.");

            // This prints a statement utilizing both of the chained constructors
            Console.WriteLine("\nMy name is {0} {1} and I am {2} years of age. Also, {3}", char1.fname, char1.lname, char1.age, species);
            Console.WriteLine("\nMy wife is {0} {1} and I am not disclosing her age, but she isn't too much older than I am.", char2.fname, char2.lname);

            // This uses the 'var' keyword to create an instance of 'Character'
            var human = new Character("Spongebob", "Square-Pants", 24);
            Console.WriteLine("\nFun Fact: {0} {1} is {2} years old and is not {3}", human.fname, human.lname, human.age, species);

            Console.ReadLine();


        }
    }
}
