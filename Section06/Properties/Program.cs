using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3, 4, 5);
            
            //box.length = 3;
            //box.SetLength(2);

            //box.Height = 3;
            //box.Width = 4;

            Console.WriteLine("Box width is " + box.Width + ".");
            Console.WriteLine("Box volume is " + box.Volume + ".");
            Console.WriteLine("Front surface area is " + box.FrontSurface + ".");

            box.DisplayInfo();
        }
    }
}
