using System;
using System.Collections;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dictionary<int, string> students = new Dictionary<int, string>();

            string name;
            int studentID;

            do
            {

                Console.WriteLine("Enter a student name:");
                name = Console.ReadLine();

                if (name.Length > 0)
                {
                    Console.WriteLine("Enter " + name + "'s ID:");
                    studentID = int.Parse(Console.ReadLine());

                    students.Add(studentID, name);
                }

            } while (name.Length > 0);

            foreach (KeyValuePair<int,string> student in students)
            {
                Console.WriteLine(student.Value + " ID:" + student.Key);
            }
        }
    }
}
