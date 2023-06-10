using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesDemo
{
    // This will declare that this class is static
    // Meaning that it only contains static methods and cannot be instantiated
    public static class Stat
    {
        // This creates a static method
        public static void writeConsole()
        {
            // This prints a statement to the console
            Console.WriteLine("This is written from a static method 'writeConsole'," + "\n" + "in a static class 'Stat'.");

        }
    }
}
