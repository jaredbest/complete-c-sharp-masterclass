using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeJaggedArray
{
    class Program
    {
        // Create a jagged array, which contains 3 "friends arrays", in which two family members should be stored
        // Introduce family members from different families to each other via console (three introductions)

        static void Main(string[] args)
        {
            string[] joesFamily = new string[] { "Martha", "Robert" };


            string[][] friendsAndFamily = new string[][]
            {
                new string[]{"Michael", "Sandy"},
                new string[]{"Frank", "Claudia"},
                new string[]{"Andrew", "Michelle"},
                joesFamily
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][0], friendsAndFamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][1]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[3][1], friendsAndFamily[2][1]);
            Console.ReadKey();
        }
    }
}
