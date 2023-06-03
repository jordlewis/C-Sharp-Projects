using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // This creates a list of integers that will be divided by the user input
        List<int> numbers = new List<int>() { 5, 18, 21, 3, 398, 14, 66, 94, 2, 999 };
        // This asks the user to input a number to divide by
        Console.WriteLine("Please input a number to divide random numbers by:");
        
        // This is the try/catch block of code for exception handling
        try
        {
            // This will convert the user input to an integer
            int userNum = Convert.ToInt32(Console.ReadLine());
            // This is the 'foreach' loop that will iterate through each index in the list 'numbers'
            foreach (int number in numbers) 
            {
                // This creates a new variable 'quot', which is the quotient of the index divided by the user input
                int quot = number / userNum;
                // This will write the mathematical equation out and print it to the console for each index
                Console.WriteLine(number + " divided by " + userNum + " equals " + quot);
            }

        }
        // This is where the exception handling begins
        // This is a format exception that will prompt if the user does not enter an integer
        catch (FormatException ex)
        {
            // This is the error message displayed to the user on the console
            Console.WriteLine("Please type a whole number.");
        }
        // This exception occurs if the user enters '0' to divide by, which is not possible
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by 0");
        }
        // This a generic exception that will prompt if the above exceptions do not apply 
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        // This executtes when the try/catch code block is done executing
        finally
        {
            Console.ReadLine();
        }
        // This message will appear on the console when the user has successfully left the try/catch block of code
        Console.WriteLine("Emerged from the try/catch block");
        Console.ReadLine();
        




















        //try
        //{
        //    Console.WriteLine("Pick a number.");
        //    int numberOne = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Picke a second number.");
        //    int numberTwo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Dividing the two...");
        //    int numberThree = numberOne / numberTwo;
        //    Console.WriteLine(numberOne + " divided by" + numberTwo + " equals " + numberThree);
        //    Console.ReadLine();
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine("Please type a whole number.");
        //    return;
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Please don't divide by 0");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.ReadLine();
        //}


    }
}

