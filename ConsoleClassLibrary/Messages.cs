using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassLibrary
{
    public class Messages
    {
        /*string title;
        string[] options;
        int indexNum;
        public Menus(string Title, string[] Options)
        {
            title = Title;
            options = Options;
            indexNum = 0;
        }*/


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

    }
}
