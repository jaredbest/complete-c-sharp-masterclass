using System;

namespace Section02.NamingConvention
{
    // Class names like ClientActivity
    class Program
    {
        // Method name like CalculateValue
        // method arguments like firstNumber
        static void Main(string[] args)
        {
            // local variables like itemCount

            // use userControl instead of usrCtr 

            // don't use numbers at the start of variable names


            // Correct
            string myName;
            int lastNum;
            bool isSaved;

            // Avoid
            // String myName;
            // Int32 lastNum;
            // Boolean isSaved;
        }
    }
}
