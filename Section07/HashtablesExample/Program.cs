using System;
using System.Collections;

namespace HashtablesExample
{
    class Program
    {
        // Key - Value
        // Car - Auto

        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Matthew", 98);
            Student stud2 = new Student(2, "Mark", 76);
            Student stud3 = new Student(3, "Luke", 43);
            Student stud4 = new Student(4, "John", 55);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            // Retrieve individual item with known id
            Student storedStudent1 = (Student)studentsTable[1];

            // Retrieve all values from hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;

                Console.WriteLine("Student ID: {0}", temp.Id);
                Console.WriteLine("Student Name: {0}", temp.Name);
                Console.WriteLine("Student GPA: {0}", temp.GPA);
            }

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID: {0}", value.Id);
                Console.WriteLine("Student Name: {0}", value.Name);
                Console.WriteLine("Student GPA: {0}", value.GPA);
            }

            Console.WriteLine("Student ID: {0}, Name: {1}, GPA {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
        }
    }

    class Student
    {
        // Property called Id
        public int Id { get; set; }
        // Property called Name
        public string Name { get; set; }
        // Property called GPA
        public float GPA { get; set; }

        // Simple constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }

}
