using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleClassLibrary
{
    public class ValidStudent
    {
        static IPerson _person;
        static NameRegex _regex;
        static int nameSelector = 0;

        public ValidStudent(IPerson person, NameRegex regex)
        {
            _person = person;
            _regex = regex;
        }

        public static int ValidateAge()
        {
            Console.WriteLine("Please enter an Age.");
            int age = 0;
            bool ageIsNotValid = true;
            while (ageIsNotValid)
            {
                bool validAge = Int32.TryParse(Console.ReadLine(), out age);
                if (validAge == false || age <= 0)
                {
                    Console.WriteLine(age + " is invalid. Please enter a valid age");
                }
                else
                {
                    ageIsNotValid = false;
                }
            }
            return age;
        }

        public static string GetValidName()
        {

            string name = "";
            bool firstNameIsNotValid = true;


            switch(nameSelector)
            {
                case 0:
                    Console.WriteLine("Please enter a First Name.");
                    nameSelector = 1;
                    break;
                case 1:
                    Console.WriteLine("Please enter a Last Name.");
                    nameSelector = 0;
                    break;

            }
            //Example, matching strings to a Regex pattern
            // Try regexr.com for practice 
            
            //_regex.regexPatterns = @"^([^0-9]*)$";

            do
            {
                Regex regexPattern = new Regex(@"^([^0-9]*)$");
                name = UserInput.GetName(name);
                Match match = regexPattern.Match(name);

                if (string.IsNullOrWhiteSpace(name) || !match.Success)
                {
                    Console.WriteLine("Please enter a valid name!");
                }
                else
                {
                    firstNameIsNotValid = false;
                }
            }
            while (firstNameIsNotValid);
            return name;
        }

    }
}