using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorDemo
{
    class Character
    {
        // This sets the properties of the 'Character' class
        public string fname;
        public string lname;
        public int age;


        // This creates the first constructor and sets the keywords to refer to the constructor properties
        //  and it takes 3 arguments
        public Character(string fname, string lname, int age)
        {
            this.fname = fname;
            this.lname = lname;
            this.age = age;
            
        }

        // This calls the first constructor using the ':this()' keyword
        // The second constructor allows for 2 arguments, instead of 3 like the first
        // and it passes in a default vaule in lieu of the third arguement of 'age'
        public Character(string fname, string lname) : this(fname, lname,  0)
        {

        }
    }
}
