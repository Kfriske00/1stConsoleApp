using ConsoleClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassLibrary
{
    public class UserInput
    {

        public static string GetName (string input)
        {
            input = Console.ReadLine();
            return input;
        }

        public static ConsoleKey GetUserSelection (ConsoleKey input)
        {
            input = Console.ReadKey(true).Key;
            return input;
        }

        public static void AddToRosterChoice(Student student)
        {
            ConsoleKey selectionChoice = ConsoleKey.A;
            bool makeSelection = true;
            do
            {
                selectionChoice = GetUserSelection(selectionChoice);
                if (selectionChoice == ConsoleKey.Y)
                {
                    //studentList.AddStudent(student);
                    makeSelection = true;
                }
                else if (selectionChoice == ConsoleKey.N)
                {
                    makeSelection = false;
                }
            }
            while (makeSelection);
        }
    }
}
