using System;
using System.Collections.Generic;
using System.Text;

namespace _1stConsoleApp
{
    public class GetStudentInfo
    { 
      
        public static Students CreateStudent()
        {
            Students user = new Students();

            Console.WriteLine("Please enter in the First Name:");
            ValidStudent.ValidateFirstName(user);
            Console.WriteLine("Please enter in the Last Name:");
            ValidStudent.ValidateLastName(user);
            Console.WriteLine("Please enter the Age:");
            ValidStudent.ValidateAge(user);
            return user;
        }
    }
}