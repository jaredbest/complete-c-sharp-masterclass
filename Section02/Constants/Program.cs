using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    // Constants are immutable values which are known 
    // at compile time and do not change for the life of the program.

    class Program
    {
        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;

        // Create a constant of type string with your birthday as its value
        const string birthday = "31.05.1988";
        const string birthday2 = "05.31.1988";
        const string birthday3 = "2018-05-31";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be: {0}", birthday);
            Console.ReadKey();
        }
    }
}