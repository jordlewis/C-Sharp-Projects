using System;

namespace MainMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // This instantiates 'classOne'
            MathClass classOne = new MathClass();

            int numbaOne = 2;
            int methodOne = classOne.MathOne(numbaOne);
            Console.WriteLine("The remainder of MathOne is {0}", methodOne);
            Console.ReadLine();
        }
    }
}
