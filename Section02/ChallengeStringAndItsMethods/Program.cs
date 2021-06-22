using System;

namespace ChallengeStringAndItsMethods
{
    class Program
    {
        /// <summary>
        /// Formats string in four ways and outputs each on line.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string myName;
            Console.Write("Please enter your name and press enter : ");
            myName = Console.ReadLine();
            
            string myNameUpperCase = String.Format("Upper case : {0}", myName.ToUpper());
            string myNameLowerCase = String.Format("Lower case : {0}", myName.ToLower());
            string myNameTrimmed = String.Format("Trimmed value : {0}", myName.Trim());
            string myNameSubstring = String.Format("Substring value : {0}", myName.Substring(0, 5));

            Console.WriteLine(myNameUpperCase);
            Console.WriteLine(myNameLowerCase);
            Console.WriteLine(myNameTrimmed);
            Console.WriteLine(myNameSubstring);
        }
    }
}
