using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasics
{
    // This class is a blueprint for a datatype.

    // Create a public variable lastName of type string.
    // Change the IntroduceMyself method, so it tells the whole name.
    // Create two objects with full information about themself - firstName and lastName

    class Human
    {
        // Fields (or member variables): Fields are variables declared at class scope. A field
        // may be a built-in numeric type or an instance of another class. For example, a calendar
        // class may have a field that contains the current date.
        private string firstName;
        private string lastName;

        // Constructor: A constructor is a method whose name is the same as the name of its type.
        // Its method signature includes only the method name and its parameter list; it does
        // not include a return type.
        public Human(string firstName, string lastName)
        {
            // firstName = myFirstName;
            // lastName = myLastName;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
        }
    }
}
