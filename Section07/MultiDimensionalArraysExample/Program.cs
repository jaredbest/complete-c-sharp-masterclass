using System;

namespace MultiDimensionalArraysExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize a 2-dimensional array
            int[,] array2D = new int[,]
            {
                {11, 12, 13 },
                {21, 22, 23 },
                {31, 32, 33 }
            };

            // We access the value 23
            // Note, that indexes start with 0
            Console.WriteLine(array2D[1, 2]);


            // 3-dimensions are more complex, but the concept is the same
            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001", "002" },
                    {"010", "011", "012" },
                    {"020", "021", "022" }
                },
                {
                    {"100", "101", "102" },
                    {"110", "111", "112" },
                    {"120", "121", "122" }
                },
                {
                    {"200", "201", "202" },
                    {"210", "211", "212" },
                    {"220", "221", "222" }
                },
                {
                    {"Hi", "I", "am" },
                    {"also", "part", "of" },
                    {"the", "3-dimensional", "array" }
                }

            };

            // We access the Value "201"
            Console.WriteLine(array3D[2, 0, 1]);

            // Hi
            Console.WriteLine(array3D[3, 0, 0]);

            // Will give us the Dimension of the corresponding Array
            int amountDimensions = array3D.Rank;
            Console.WriteLine("The Dimension is {0}", amountDimensions);

            // Multi-dimensional Arrays can also be created that way:
            string[,] arr2D = { { "00", "01" } };

            Console.WriteLine(arr2D[0, 0]);

            // To keep the Console open
            Console.Read();
        }
    }
}
