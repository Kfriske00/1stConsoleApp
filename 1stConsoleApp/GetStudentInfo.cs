using System;
using System.Collections.Generic;
using System.Text;

namespace _1stConsoleApp
{
    public class GetStudentInfo
    { 
      
        public static Student CreateStudent()
        {

            Console.WriteLine("Please enter in the First Name:");
            string firstName = ValidStudent.GetValidName();
            Console.WriteLine("Please enter in the Last Name:");
            string lastName = ValidStudent.GetValidName();
            Console.WriteLine("Please enter the Age:");
            int age = ValidStudent.ValidateAge();
            return new Student(firstName, lastName, age);
            
        }
    }
}