using System;

namespace BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the will take the user input and multiply it by 50
            // This asks the user to input a number
            Console.WriteLine("Please input a number..");
            // This will assign the number to a string variable, then convert it to an integer
            string useNumA = Console.ReadLine();
            // This will convert the string "useNumA" to a long
            long userNumberA = Convert.ToInt64(useNumA);
            // This will multiply the user's number by 50
            long product = userNumberA * 50;
            string stateA = String.Format("{0} multiplied by 50 is {1}", userNumberA, product);
            Console.WriteLine(stateA);

            // This is the will take the user input and add 25 to it
            // This asks the user to input a new number
            Console.WriteLine("Please input a new number..");
            // This will assign the number to a string variable, then convert it to an integer
            string useNumB = Console.ReadLine();
            // This will convert the string "useNumB" to a long
            long userNumberB = Convert.ToInt64(useNumB);
            // This will provide the sum of the user input and 25
            long sum = userNumberB + 25;
            string stateB = String.Format("The sum of {0} and 25 is {1}", userNumberB, sum);
            Console.WriteLine(stateB);

            // This is the will take the user input and divide it by 12.5
            // This asks the user to input a new number
            Console.WriteLine("Please input a new number..");
            // This will assign the number to a string variable, then convert it to a double
            string useNumC = Console.ReadLine();
            // This will convert the string "useNumC" to a double
            double userNumberC = Convert.ToDouble(useNumC);
            // This will provide the quotient of the user input and 12.5
            double quotient = userNumberC / 12.5D;
            string stateC = String.Format(" {0} divided by 12.5 is {1}", userNumberC, quotient);
            Console.WriteLine(stateC);

            // This is the will take the user input and check if it is greater than 50, then prints 'true' or 'false' to the console
            // This asks the user to input a new number
            Console.WriteLine("Please input a new number..");
            // This will assign the number to a string variable, then convert it to an integer
            string useNumD = Console.ReadLine();
            // This will convert the string "useNumB" to a long
            long userNumberD = Convert.ToInt64(useNumD);
            // This will use an if/else statement to check if the user input is greater, or less than 50 and print the respective output
            if (userNumberD > 50)
            {
                Console.WriteLine("True -- Your number is greater than 50.");
            }
            else
            {
                Console.WriteLine("False -- Your number is less than 50.");
            }

            // This is the will take the user input and divides it by 7, then prints the remainder to the console using the modulus operator
            // This asks the user to input a new number
            Console.WriteLine("Please input a new number..");
            // This will assign the number to a string variable, then convert it to an double
            string useNumE = Console.ReadLine();
            // This will convert the string "useNumE" to a long
            double userNumberE = Convert.ToDouble(useNumE);
            // This will provide the reaminder of the user input and 7 using the modulus operator
            double remain = userNumberE % 7;
            string stateE = String.Format("The remainder of {0} and 7 is {1}", userNumberE, remain);
            Console.WriteLine(stateE);
            Console.ReadLine();

        }
    }
}
