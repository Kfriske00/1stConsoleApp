using ConsoleClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1stConsoleApp
{
    public static class SchoolLogic
    {
        public static IPerson CreateStudent(string Firstname, string Lastname, int Age)
        {
            return new Student(Firstname, Lastname, Age);
        }

        public static IPerson CreateTeacher()
        {
            return new Teacher();
        }

        public static IRoster CreateRoster(string rosterName)
        {
            return new Roster(rosterName);
        }

        public static ValidStudent ValidateInfo()
        {
            return new ValidStudent(CreateTeacher(), GetNameRegex());
        }

        public static IGetPersonInfo GetPersonInfo ()
        {
            return new GetPersonInfo();
        }

        public static NameRegex GetNameRegex()
        {
            return new NameRegex();
        }
    }
}
