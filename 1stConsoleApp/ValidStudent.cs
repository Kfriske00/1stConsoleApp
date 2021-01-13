using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _1stConsoleApp
{
    public class ValidStudent
    {
        public static void ValidateAge(Students user)
        {
            int age;
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
                    user.age = age;
                    ageIsNotValid = false;
                }
            }
        }
        public static void ValidateFirstName(Students user)
        {
            string firstName;
            bool firstNameIsNotValid = true;

            /*Example, matching strings to a Regex pattern
             * Try regexr.com for practice */

            string regexPattern = @"^([^0-9]*)$";
            Regex regex = new Regex(regexPattern);
            

            while (firstNameIsNotValid)
            {
                firstName = Console.ReadLine();
                Match match = regex.Match(firstName);

                if (string.IsNullOrWhiteSpace(firstName) || !match.Success)
                {
                    Console.WriteLine("Please enter a valid First Name!");
                }
                else
                {
                    user.firstName = firstName;
                    firstNameIsNotValid = false;
                }
            }

        }

        public static void ValidateLastName(Students user)
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
        }
    }
}