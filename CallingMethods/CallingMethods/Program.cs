using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // This instantiates the public class as 'testClass'
            MyClass testClass = new MyClass();
            // This prompts the user to enter a number to pass along to all 3 methods inside testClass
            Console.WriteLine("Please ennter a number to pass through 3 different methods:");
            // This will convert the user input to an integer
            int userInput = Convert.ToInt32(Console.ReadLine());
            // This will pass the user input through the first method and print out a statment with the result of the equation
            int meth1 = testClass.timesTen(userInput);
            Console.WriteLine("{0} * 10 = {1}", userInput, meth1);
            // This will pass the user input through the second method and print out a statment with the result of the equation
            int meth2 = testClass.inHalf(userInput);
            Console.WriteLine("{0} / by 2 = {1}", userInput, meth2);
            // This will pass the user input through the third method and print out a statment with the result of the equation
            int meth3 = testClass.highNum(userInput);
            Console.WriteLine("{0} +  3521479 = {1}", userInput, meth3);

            Console.ReadLine();

        }
    }        
}
