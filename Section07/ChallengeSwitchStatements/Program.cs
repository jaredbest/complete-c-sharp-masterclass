using System;

namespace ChallengeSwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean valid = false;
            string inputValueType;

            Console.Write("Enter a value:");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Select the data type to validate the input you have entered.");
            Console.WriteLine("Press 1 for String.");
            Console.WriteLine("Press 2 for Integer.");
            Console.WriteLine("Press 3 for Boolean.");

            Console.Write("Enter:");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch(inputType)
            {
                case 1:
                    // Check for string
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;
                case 2:
                    int retValue = 0;
                    // Check for integer
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    Boolean retFlag = false;
                    // Check for boolean
                    valid = Boolean.TryParse(inputValue, out retFlag);
                    inputValueType = "Boolean";
                    break;
                default:
                    inputValueType = "Unknown";
                    Console.WriteLine("Not able to detect the input type, something is wrong.");
                    break;
            }

            Console.WriteLine("You have entered a value: {0}", inputValue);

            if(valid)
            {
                Console.WriteLine("It is valid: {0}", inputValueType);
            }
            else
            {
                Console.WriteLine("It is invalid: {0}", inputValueType);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Method to check if the input string is a pure letter string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static bool IsAllAlphabetic(string value)
        {
            foreach(char c in value)
            {
                if(!char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
