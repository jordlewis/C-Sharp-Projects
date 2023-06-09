using System;

namespace MoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //----THIS IS 1ST SUBMISSION----

            // This instantiates the class 'aClass'
            ClassA aClass = new ClassA();
            // This asks the user to input the first number
            Console.WriteLine("Please enter the first number---:");
            // This converts the user input to an integer
            int number1 = Convert.ToInt32(Console.ReadLine());
            // This prompts the user to enter a second optional number
            Console.WriteLine("Please enter a second number (optional; You do not have to enter a value if you so choose)---:");
            // This will pull the user input
            string optNum = Console.ReadLine();
            // This sets the default value of 'number2' to 0
            int number2 = 0;
            // Checks to see if the user entered a second number, or if it's empty
            if (!string.IsNullOrEmpty(optNum))
            {
                // If the user did input a second number, this converts it to an integer to be passed to the method
                number2 = Convert.ToInt32(optNum);
            }

            // Calls the method and passes at least 1 number the user entered to the method, and an optional second number. 
            // If there is not a second number, the value will default to '0'
            int result = aClass.MethodA(number1, number2);
            Console.WriteLine(result);

            //----THIS IS 2ND SUBMISSION----

            ClassA bClass = new ClassA();

            // Call Method 1 with two numbers entered
            int number3 = 2;
            int number4 = 69;
            bClass.MethodB(number3, number4);

            // Call Method 1 with parameters specified by name
            bClass.MethodB(number3: number3, number4: number4);

            Console.ReadLine();
        }
    }
}
