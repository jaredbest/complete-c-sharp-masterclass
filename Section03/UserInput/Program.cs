using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //Console.WriteLine(input);
            //Console.Read();
            Console.WriteLine(Calculate());
            Console.Read();
        }

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number.");
            string numberOneInput = Console.ReadLine();

            Console.WriteLine("Please enter the second number.");
            string numberTwoInput = Console.ReadLine();

            int num1 = int.Parse(numberOneInput);
            int num2 = int.Parse(numberTwoInput);

            int result = num1 + num2;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is");
            return result;
        }
    }
}
