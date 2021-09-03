using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndSealed
{
    public class SealedMethods
    {
        public virtual void DoSomething()
        {

        }
    }

    public class SealingClass : SealedMethods
    {
        public sealed override void DoSomething()
        {
            //base.DoSomething();
            Console.WriteLine("This method is not going to be overriden by deriving class");
        }
    }
}
