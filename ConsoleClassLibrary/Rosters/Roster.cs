using ConsoleClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ConsoleClassLibrary
{
    public class Roster : IRoster
    {
        public string rosterName;
        //To reference the SchoolLogic class and avoid circlular dependencies I would have to create a third project and just have the other 2 projects reference it. Exactly the same thing I am doing with the SchoolLogic class. (Reminder of why I need to do this: it will crash because I haven't actually created a new list yet. I am trying to use my School Logic to do that)
        public List<IPerson> personRoster { get; set; }
        public Roster(string name)
        {
            rosterName = name;
        }

        public void AddPerson(IPerson person)
        {
            personRoster.Add(person);
            Console.WriteLine($"Student {person.firstName} added to the Roster!");
        }
        
        public override string ToString()
        {
            return $"Roster: {rosterName}\nNumber of Students: {personRoster.Count}";
        }

        public void PrintRoster()
        {
            Console.WriteLine(this.ToString());
            foreach (IPerson person in personRoster)
            {
                person.PrintPerson();
            }

        }

    }
}
