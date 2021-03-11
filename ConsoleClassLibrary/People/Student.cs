using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleClassLibrary
{

    public class Student : IPerson
    {
        public string firstName { get; set; }
        private string lastName;
        public int age { get; set; }
        public int idNumber { get; private set; }
        Random idNum = new Random();
        public override string ToString()
        {
            return $"Student: {firstName} {lastName}\nAge: {age}\nStudent ID: {idNumber}\n";
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
            idNumber = idNum.Next(1, 10000);

        }
        public void PrintStudent()
        {
            Console.WriteLine(ToString());
        }

    }
}

