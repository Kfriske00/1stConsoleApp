using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassLibrary
{
    public class Teacher : IPerson
    {
        public int age { get; set; }
        public string firstName { get; set; }

        public int idNumber { get; }

        public string LastName { get; set; }


        
    }
}
