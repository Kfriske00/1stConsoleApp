using System;
using System.Collections.Generic;
using System.Text;

namespace _1stConsoleApp
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
    }
}
