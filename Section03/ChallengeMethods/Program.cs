using System;

namespace ChallengeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string friendOne = "Phoebe Buffay";
            string friendTwo = "Chandler Bing";
            string friendThree = "Joey Tribbiani";

            GreetFriend(friendOne);
            GreetFriend(friendTwo);
            GreetFriend(friendThree);

            Console.Read();
        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi " + friendName + ", my friend!");
        }
    }
}
