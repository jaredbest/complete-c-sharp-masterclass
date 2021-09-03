using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read text from a file
            // Exchange the address of the file with the one you want to use
            string text = System.IO.File.ReadAllText(@"D:\C# Masterclass Course\Projects\Assets\textfile.txt");

            Console.WriteLine("Textfile contains the following text: {0}", text);

            // Receive the Text line by line.
            string[] lines = System.IO.File.ReadAllLines(@"D:\C# Masterclass Course\Projects\Assets\textfile.txt");

            Console.WriteLine("Content of the file line by line:");
            foreach (string line in lines)
            {
                // \t is a tab
                Console.WriteLine( "\t" + line);
            }

            // Keep the Console open
            Console.Read();
        }
    }
}
