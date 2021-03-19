using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassLibrary
{
    public abstract class Person : IPerson
    {
        public int age { get; set; }

        public string lastName;
        public string firstName { get; set; }

        public int idNumber { get; set; }


        Random idNum = new Random();
        public new string ToString()
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
        public void PrintPerson()
        {
            Console.WriteLine(ToString());
        }

    }
}
