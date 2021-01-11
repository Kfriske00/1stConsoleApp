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
            bool isMatch;
            bool firstNameIsNotValid = true;

            /*Example, matching strings to a Regex pattern
             * Try regexr.com for practice */

            string pattern = @"^([^0-9]*)$";
            Regex rg = new Regex(pattern);
            

            while (firstNameIsNotValid)
            {
                firstName = Console.ReadLine();
                isMatch = rg.IsMatch(firstName);

                if (string.IsNullOrWhiteSpace(firstName) || !isMatch)
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
            while (lastNameIsNotValid)
            {
                if (string.IsNullOrWhiteSpace(lastName = Console.ReadLine()))
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