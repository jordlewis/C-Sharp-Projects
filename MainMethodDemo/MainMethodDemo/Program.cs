using System;

namespace MainMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // This instantiates 'classOne'
            MathClass classOne = new MathClass();

            // This assigns a value of 2 to the variable 'numbaOne'
            int numbaOne = 2;
            // This will pass the numbaOne variable to the classOne method
            int methodOne = classOne.MyMath(numbaOne);
            // This will print a statement and returns an integer
            Console.WriteLine("The remainder of MathOne is {0}", methodOne);

            // This assigns a value of 2 to the variable 'numbaTwo'
            decimal numbaTwo = 9.3m;
            // This will pass the numbaTwo variable to the classOne method
            int methodTwo = classOne.MyMath(numbaTwo);
            // This will pass the numbaTwo variable to the classOne method
            Console.WriteLine("The product of MathOne is {0}", methodTwo);

            // This assigns a value of 2 to the variable 'numbaThree'
            string numbaThree = "9";
            // This will pass the numbaThree variable to the classOne method
            int methodThree = classOne.MyMath(numbaThree);
            // This will pass the numbaThree variable to the classOne method
            Console.WriteLine("The sum of MathOne is {0}", methodThree);

            Console.ReadLine();
        }


    }
}
