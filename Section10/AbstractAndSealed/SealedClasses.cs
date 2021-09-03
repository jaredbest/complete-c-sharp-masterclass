using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndSealed
{
    // Classes can be declared as sealed 
    // by putting the keyword sealed before the class definition. 
    // Why?
    // Because they can never be used as a base class, 
    // some run-time optimizations can make calling sealed class members slightly faster.
    public sealed class SealedClasses
    {
    }

    /*
    public class TryingToInherit : SealedClasses
    {

    }
    */
}
