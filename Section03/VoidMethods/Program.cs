using System;

namespace VoidMethods
{
    class Program
    {

        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument and am called from a method");
            Console.Read();
        }

        // <Access modifier> (static) <return type> <method name> (parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}
