using ConsoleClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassLibrary
{
    public class Roster
    {
        private string rosterName;
        public List<Student> StudentRoster { get; set; } = new List<Student>();

        public Roster() { }
        
        public Roster(string name)
        {
            rosterName = name;
        }
        

        public void AddStudent(Student student)
        {
            StudentRoster.Add(student);
            Console.WriteLine($"Student {student.firstName} added to the Roster!");
        }
        public override string ToString()
        {
            return $"Roster: {rosterName}\nNumber of Students: {StudentRoster.Count}";
        }

        public void PrintRoster()
        {
            Console.WriteLine(this.ToString());
            foreach (Student student in StudentRoster)
            {
                student.PrintStudent();
            }

        }



    }
}
