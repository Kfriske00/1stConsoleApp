using System.Collections.Generic;

namespace ConsoleClassLibrary
{
    public interface IRoster
    {
        List<IPerson> personRoster { get; set; }

        void AddPerson(IPerson person);
        void PrintRoster();
        string ToString();
    }
}