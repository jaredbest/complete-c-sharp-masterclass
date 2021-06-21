using System;

namespace Section02.TypeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;
            // explicit conversion
            // cast double to int;
            myInt = (int)myDouble;

            // typeConversion 
            string myString = myDouble.ToString(); // "13.37"
            string myFloatString = myFloat.ToString();
            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.Read();
        }
    }
}
