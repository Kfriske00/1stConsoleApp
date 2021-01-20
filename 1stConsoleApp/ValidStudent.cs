using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _1stConsoleApp
{
    public class ValidStudent
    {
        public static int ValidateAge()
        {
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
            string firstName = "";
            bool firstNameIsNotValid = true;

            /*Example, matching strings to a Regex pattern
             * Try regexr.com for practice */

            string regexPattern = @"^([^0-9]*)$";
            Regex regex = new Regex(regexPattern);

            do
            {
                firstName = Console.ReadLine();
                Match match = regex.Match(firstName);

                if (string.IsNullOrWhiteSpace(firstName) || !match.Success)
                {
                    Console.WriteLine("Please enter a valid First Name!");
                }
                else
                {

                    firstNameIsNotValid = false;

                }
            }
            while (firstNameIsNotValid);
             return firstName;
        }
       /* public static void ValidateLastName(Student user)
        {
            string lastName;
            bool lastNameIsNotValid = true;

            string regexPattern = @"^([^0-9]*)$";
            Regex regex = new Regex(regexPattern);

            while (lastNameIsNotValid)
            {
                lastName = Console.ReadLine();
                Match match = regex.Match(lastName);

                if (string.IsNullOrWhiteSpace(lastName) || !match.Success)
                {
                    Console.WriteLine("Please enter a valid Last Name!");
                }
                else
                {
                    user.lastName = lastName;
                    lastNameIsNotValid = false;
                }
            }
        }*/
    }
}