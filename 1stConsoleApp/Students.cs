using System;
using System.Collections.Generic;
using System.Text;


namespace _1stConsoleApp
{

    public class Students
    {

        public string firstName { get; set; }
        public string lastName;

        public override string ToString()
        {
            return $"Student: {firstName} {lastName}\nAge: {age}\nStudent ID: {studentID}\n"; 
        }
        public int age { get; set; }
        public int studentID { get; private set; }
        Random sid = new Random();



        public Students()
        {
            studentID = sid.Next(1, 10000);
        }
        public string sLastName
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
        public Students(string Firstname, string Lastname, int Age) : this()
        {
            firstName = Firstname;
            lastName = Lastname;
            age = Age;
        }

        public void AddToRoster(Roster roster)
        {
            roster.StudentRoster.Add(this);
        }
        public void PrintStudent()
        {
            Console.WriteLine(this.ToString());
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
        public List<Students> GetList
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

