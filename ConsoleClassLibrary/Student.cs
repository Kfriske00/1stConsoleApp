﻿using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleClassLibrary
{

    public class Student
    {
        public string firstName { get; set; }
        private string lastName;
        public int age { get; set; }
        public int studentID { get; private set; }
        Random sid = new Random();
        public override string ToString()
        {
            return $"Student: {firstName} {lastName}\nAge: {age}\nStudent ID: {studentID}\n";
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                Console.WriteLine($"The last name of {firstName} has been changed to {value}");
                lastName = value;
            }

        }
        public Student(string Firstname, string Lastname, int Age)
        {
            firstName = Firstname;
            lastName = Lastname;
            age = Age;
            studentID = sid.Next(1, 10000);

        }

        /*public void AddToRoster(Roster roster)
        {
            roster.StudentRoster.Add(this);
        }*/
        public void PrintStudent()
        {
            Console.WriteLine(ToString());
        }

        /*
        public void WriteToConsole()
        {
            foreach (object o in lstStudents)
            {
                Console.WriteLine(o.);
            }
        }
        */
        /*
        public List<Student> GetList
        {    
            

            get { return lstStudents; }
        }
        */

        /*
        public void aList()
        {
            foreach (var student in lstStudents)
            {
                Console.WriteLine($"{lstStudents[1]}");
            }
        }*/
    }
}
