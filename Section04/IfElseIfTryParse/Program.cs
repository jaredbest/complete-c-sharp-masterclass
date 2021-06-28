using System;

namespace IfElseIfTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature outside?");
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);

            if (numTemp < 20)
            {
                Console.WriteLine("Wear a jacket.");
            }

            if (numTemp == 20)
            {
                Console.WriteLine("Pants and a light sweater should be fine.");
            }

            if (numTemp > 20)
            {
                Console.WriteLine("Wear shorts.");
            }

            Console.Read();
        }
    }
}
