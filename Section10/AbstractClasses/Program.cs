using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Sphere(4), new Cube(3) };

            foreach(Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("{0} has a volume of {1}.", shape.Name, shape.Volume());

                Cube iceCube = shape as Cube;

                if(iceCube == null)
                {
                    Console.WriteLine("This shape is not a cube.");
                }

                if(shape is Cube)
                {
                    Console.WriteLine("This shape is a cube.");
                }

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;

                Console.WriteLine("{0} has a volume of {1}.", cube2.Name, cube2.Volume());
            }
        }
    }
}
