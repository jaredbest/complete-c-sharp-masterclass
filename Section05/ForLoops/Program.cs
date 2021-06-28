using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter < 20; counter += 2)
            {
                Console.WriteLine(counter);
            }
            Console.Read();
        }
    }
}