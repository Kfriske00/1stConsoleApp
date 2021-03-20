using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassLibrary
{
    public class Messages
    {
        public static void StartMessage()
        {
            Console.WriteLine("Hello! Welcome to my first Console Program! To get started lets create a student!");
        }

        public static void EndMessage()
        {
            Console.WriteLine("Thank you for trying out my Application!");
        }

        public static void AddToListChoice()
        {
            Console.WriteLine("Student created! Would you like to add a new student to the Student Roster?\n(Y)es or (N)o");
        }

        public void OnFullRoster(object source, RosterEventArgs e)
        {
            Console.WriteLine($"{e.roster.rosterName} is full!");
        }
        
    }
}
