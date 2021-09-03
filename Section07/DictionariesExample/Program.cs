using System;
using System.Collections.Generic;

namespace DictionariesExample
{
    class Program
    {
        // Key - Value
        // Car - Auto

        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("CEO", "Denis", 42, 200),
                new Employee("Manager", "Laura", 27, 100),
                new Employee("HR", "Steven", 51, 40),
                new Employee("Lead Developer", "Chris", 29, 50),
                new Employee("Intern", "Karin", 21, 10),
                new Employee("Mailroom Guy", "Kenny", 66, 30),
            };

            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two" },
                {3, "three" }
            };

            Dictionary<string, Employee> employeeDirectory = new Dictionary<string, Employee>();

            foreach (Employee emp in employees)
            {
                employeeDirectory.Add(emp.Role, emp);
            }

            string key = "CEO";
            if(employeeDirectory.ContainsKey(key))
            {
                Employee empl = employeeDirectory[key];
                Console.WriteLine("Employee name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary);
            }
            else
            {
                Console.WriteLine("No employee found with this key: {0}", key);
            }
        }
    }

    class Employee
    {
        // Properties like role, name, age, and rate

        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        // Salary = rate/h * number of days * number of weeks * number of months

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        // Simple constructor
        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = Rate;
        }
    }
}
