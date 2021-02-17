using System;
using System.Collections.Generic;
using System.Linq;

namespace _1stConsoleApp
{   
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey keyInput = ConsoleKey.A;
            Roster studentList = new Roster("Students");
            Roster CS115 = new Roster("CS115");

            Messages.StartMessage();
            
            
            studentList.AddStudent(GetStudentInfo.CreateStudent());
            studentList.PrintRoster();
            CS115.PrintRoster();
            //students.AddToRoster(studentList);

            bool run = true;
            Console.WriteLine("Student created! Would you like to add a new student to the Student Roster?\n(Y)es or (N)o");
            do
            {

                keyInput = UserInput.GetUserSelection(keyInput);
                if ( keyInput == ConsoleKey.Y)
                {
                    studentList.AddStudent(GetStudentInfo.CreateStudent());
                    run = true;
                }
                else if (keyInput == ConsoleKey.N)
                {
                    run = false;
                }
            }
            while (run);
            
            Console.WriteLine("Do you want to display the Roster?\n(Y)es or (N)o");
            keyInput = Console.ReadKey(true).Key;

            if (keyInput == ConsoleKey.Y)
                {
                    studentList.PrintRoster();
                }
                            /*
             var s11 = new Student("Karla", "Jackle", 35);
            var s12 = new Student("Jimmy", "Biggie", 112);
            new Student("J", "C", 900);
            foreach (var student in studentList.StudentRoster)
            {
                student.PrintStudent();
            }
            */
            Console.Read();
            //ffffffffffffffffoooooooooooooooooooooooooooooooooooooooo

            /*
            var run = true;
            Console.WriteLine("Welcome to Lil'PPs Fake School System! Please enter one of the following:\n 1.) Add Student to Roster\n 2.) Change a students last name\n 3.) Search a student by last name\n 4.) Nothing\n 5.)Exit");
            while (run)```
            {
                
                //var option = Console.ReadKey().Key;
                

                switch(Console.ReadKey(false).Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Adding students to roster...");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        s11.AddToRoster(studentList);
                        s12.AddToRoster(studentList);
                        s13.AddToRoster(CS115);

                        Console.WriteLine("List count: " + studentList.StudentRoster.Count());
                        foreach (var student in studentList.StudentRoster)
                        {
                            student.PrintStudent();
                        }

                        break;
                    case ConsoleKey.D2:
                        s11.LastName = Console.ReadLine();
                        Console.WriteLine(s11.LastName);
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine("Please enter the last name of the student you want to search");
                        var ssLastName = Console.ReadLine();
                        foreach (var student in studentList.StudentRoster)
                        {
                            if (student.LastName``````````````````````````.Contains(ssLastName))
                            {
                                student.PrintStudent();
                            }
                            else
                            {
                                Console.WriteLine($"There is no students that contains {ssLastName}");
                            }
                        }
                        break;
                    case ConsoleKey.D4:

                        string[] Options = { "NO", "YES" };
                        string Title = "Hello";
                        Menus newStart = new Menus(Title, Options);
                        newStart.Display1();
                        break;
                    case ConsoleKey.D5:
                        run = false;
                        break;
            

                }
            
            }
            */
            

        }
    }
}