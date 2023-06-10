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
                int result = aClass.MethodA(number1, number2);
                Console.WriteLine(result);
            }
            else
            {
                int result = aClass.MethodA(number1);
                Console.WriteLine(result);
            }



            //----THIS IS 2ND SUBMISSION----

            // This instantiates the class 'bClass'
            ClassB bClass = new ClassB();
            // This will call methodB and pass the 2 integer arguments to the method
            int number3 = 2;
            int number4 = 69;
            bClass.MethodB(number3, number4);

            // Call methodB with parameters specified by variable names
            bClass.MethodB(number3: number3, number4: number4);

            Console.ReadLine();
        }
    }
}
