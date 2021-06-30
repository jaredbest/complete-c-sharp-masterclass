using System;
using System.Diagnostics;

namespace Members
{
    class Members
    {
        // Private fields
        private string memberName;
        private string jobTitle;
        private int salary;

        // Public field
        public int age;

        // Property (exposes jobTitle safely)
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // Public method
        public void Introduce(bool isFriend)
        {
            if(isFriend)
            {
                SharePrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old.", memberName, jobTitle, age);
            }
        }

        // Private method
        private void SharePrivateInfo()
        {
            Console.WriteLine("My salary is {0}.", salary);
        }

        // Constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";

            Console.WriteLine("Object created.");
        }

        // Finalizer (historically referred to as Destructor)
        ~Members()
        {
            // Cleanup statements
            Console.WriteLine("Finalizer executed.");
            Debug.Write("Finalizer executed.");
        }
    }
}
