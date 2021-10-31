using System;
using System.Text.RegularExpressions;

namespace RegexT
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a regular expression with a pattern
            Regex regex = new Regex(@"\d");

            // Test string
            string text = "Hi there 123";

            // Find hits
            MatchCollection hits = regex.Matches(text);

            Console.WriteLine("{0} hits found:\n   {1}",
                              hits.Count,
                              text);

            // Amount of hits
            foreach (Match aHit in hits)
            {
                GroupCollection groups = aHit.Groups;
                Console.WriteLine("'{0}' found at {1}",
                                  groups["word"].Value,
                                  groups[0].Index
                                 );
            }
            Console.ReadLine();
        }
    }
}