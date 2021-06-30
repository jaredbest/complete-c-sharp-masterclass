using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Box
    {
        // Fields (member variables)
        private int length = 3;
        private int height;
        //public int width;
        //public int volume;

        // Type prop and then hit tab on keyboard twice to auto-create a property template.

        // Create property (Option 1)
        public int Width { get; set; }
        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
        }

        // Create property (Option 2)
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if(value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }

        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be greater than 0.");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        /*
        public int GetVolume()
        {
            return this.length * this.height * this.Width;
        }
        */

        public int FrontSurface
        {
            get { return height * length; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, and width is {2}. Therefore, the " +
                "volume is {3}.", length, height, Width, Volume);
        }
    }
}
