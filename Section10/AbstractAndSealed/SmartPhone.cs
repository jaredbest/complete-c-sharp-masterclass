using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndSealed
{
    // needs to implement methods that are defined as abstract in its base class

    class SmartPhone : Phone
    {
        public override void Call(int number)
        {
            // throw new NotImplementedException();
            Console.WriteLine("Call number: {0}", number);
        }
    }
}
