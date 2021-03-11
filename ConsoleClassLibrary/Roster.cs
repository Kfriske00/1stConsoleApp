using ConsoleClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassLibrary
{
    public class Roster : IRoster
    {
        public string rosterName;
        public List<Student> personRoster { get; set; } = new List<Student>();

       // public Roster() { }

        public Roster(string name)
        {
            rosterName = name;
        }


        public void AddStudent(Student student)
        {
            personRoster.Add(student);
            Console.WriteLine($"Student {student.firstName} added to the Roster!");
        }
        public override string ToString()
        {
            return $"Roster: {rosterName}\nNumber of Students: {personRoster.Count}";
        }

        public void PrintRoster()
        {
            Console.WriteLine(this.ToString());
            foreach (Student student in personRoster)
            {
                student.PrintStudent();
            }

        }



    }
}
