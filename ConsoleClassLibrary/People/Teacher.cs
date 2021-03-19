using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassLibrary
{
    public class Teacher : Person, IPerson
    {
        Random idNum = new Random();

        public Teacher(string Firstname, string Lastname, int Age)
        {
            firstName = Firstname;
            lastName = Lastname;
            age = Age;
            idNumber = idNum.Next(1, 10000);
        }

    }
}
