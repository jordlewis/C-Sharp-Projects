using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass testClass = new MyClass();
            Console.WriteLine("Please ennter a number to pass through 3 different methods:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int meth1 = testClass.timesTen(userInput);
            Console.WriteLine("{0} * 10 = {1}", userInput, meth1);
            int meth2 = testClass.inHalf(userInput);
            Console.WriteLine("{0} / by 2 = {1}", userInput, meth2);
            int meth3 = testClass.highNum(userInput);
            Console.WriteLine("{0} +  3521479 = {1}", userInput, meth3);



            Console.ReadLine();

        }
    }        
}
