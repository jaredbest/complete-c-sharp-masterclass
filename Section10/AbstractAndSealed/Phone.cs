using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndSealed
{
    // The abstract keyword enables you to create classes and class members 
    // that are incomplete and must be implemented in a derived class.

    // an abstract class cannot be instatiated
    // The purpose of an abstract class is to provide a common definition 
    // of a base class that multiple derived classes can share.

    // make class abstract
    public abstract class Phone
    {
        // this method is not implemented, hence does not have a method body
        public abstract void Call(int number);

    }
}
