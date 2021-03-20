using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassLibrary
{
    public class RosterEventArgs : EventArgs
    {
        public Roster roster { get; set; }
    }
}
