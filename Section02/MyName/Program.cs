using System;

namespace Section02.MyName
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname = "Jared";
            string message = "My name is " + myname;
            string capsMessage = message.ToUpper();
            string lowerCaseMessage = message.ToLower();

            Console.WriteLine(lowerCaseMessage);
            Console.Read();
        }
    }
}