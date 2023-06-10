using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    // This creates the public interface 'IQuittable'
    public interface IQuittable
    {
        // Defining the IQuittable interface with the method 'Quit()'
        // Any class that inherits the inherits the interface must implment the method
        void Quit();
    }
}
