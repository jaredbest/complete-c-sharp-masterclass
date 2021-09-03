using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndSealed
{
    public class VirtualToAbstract
    {
        // if a method is virtual, it can be overriden by a deriving class with 
        // an abstract method
        public virtual void DoSomething()
        {
            Console.WriteLine("Doing something usefull");
        }
    }

    // don't create multiple classes in the same file! Only for demo!
    public abstract class MyAbstractClass:VirtualToAbstract
    {
        public abstract override void DoSomething();
    }

    public class DerivingClassWithImplementation : MyAbstractClass
    {
        public override void DoSomething()
        {
            Console.WriteLine("Doing something in my deriving class");
        }
    }
}
