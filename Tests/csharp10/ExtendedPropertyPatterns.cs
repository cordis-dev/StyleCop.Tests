using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Person
    {
        public string? FirstName { get; set; }
        public int YearOfBirth { get; set; }
    }

    public class Developer : Person
    {
        public Manager? Manager { get; set; }
    }

    public class Manager : Person
    {
    }

    public class Test2
    {
        public static void T(object obj)
        {
            if (obj is Developer { Manager.FirstName: "Thomas" } developerWithThomasAsManager)
            {
                // Use the developerWithThomasAsManager variable here
            }
        }
    }
}
