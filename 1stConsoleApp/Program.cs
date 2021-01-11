using System;
using System.Collections.Generic;
using System.Linq;

namespace _1stConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Roster studentList = new Roster();
            Roster CS115 = new Roster();

            Messages.StartMessage();

            Students students = GetStudentInfo.CreateStudent();
            /*
            bool isNamesValid = ValidStudent.ValidNames(students);
            //bool isAgeValid = ValidStudent.ValidAge(students);
            
            if(isNamesValid == false)
            {
                Messages.EndApp();
            }
            */
            
            
            //var s1 = new Students(menus.fName, menus.lName, aAge); 
            Console.WriteLine("Student created! Would you like to add the new student to the Student Roster?\n(Y)es or (N)o");
            bool run = true;
            while (run)
            {
                if (Console.ReadKey(false).Key == ConsoleKey.Y)
                {
                    students.AddToRoster(studentList);
                    Console.WriteLine($"Student {students.firstName} added to the Roster!");
                    run = false;
                }
                else if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    run = false;
                }
            }
            Console.WriteLine("Do you want to display the Roster?\n(Y)es or (N)o");
            run = true;
            while (run)
            {
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    foreach (var student in studentList.StudentRoster)
                    {
                        student.PrintStudent();
                    }
                }
                else if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    run = false;
                }
            }
            var s11 = new Students("Karla", "Jackle", 35);
            var s12 = new Students("Jimmy", "Biggie", 112);
            new Students("J", "C", 900);
            foreach (var student in studentList.StudentRoster)
            {
                student.PrintStudent();
            }

            Console.Read();
            /*Console.WriteLine(s11);
            s11.sLastName = "Biggie";```````````````
            Console.WriteLine($"{s11} {s12}");*/


            /*
            var run = true;
            Console.WriteLine("Welcome to Lil'PPs Fake School System! Please enter one of the following:\n 1.) Add Students to Roster\n 2.) Change a students last name\n 3.) Search a student by last name\n 4.) Nothing\n 5.)Exit");
            while (run)
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
                        s11.sLastName = Console.ReadLine();
                        Console.WriteLine(s11.sLastName);
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine("Please enter the last name of the student you want to search");
                        var ssLastName = Console.ReadLine();
                        foreach (var student in studentList.StudentRoster)
                        {
                            if (student.sLastName.Contains(ssLastName))
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