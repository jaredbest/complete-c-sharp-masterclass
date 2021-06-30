using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Human sissy = new Human("Sissy", "Wagner");
            sissy.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
