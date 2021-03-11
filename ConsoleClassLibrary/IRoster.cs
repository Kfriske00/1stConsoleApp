using System.Collections.Generic;

namespace ConsoleClassLibrary
{
    public interface IRoster
    {
        List<Student> personRoster { get; set; }

        void AddStudent(Student student);
        void PrintRoster();
        string ToString();
    }
}