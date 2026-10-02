using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Reference
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string CatchPhrase { get; set; }

        public Employee(string name, string title, string catchPhrase)
        {
            Name = name;
            Title = title;
            CatchPhrase = catchPhrase;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I am {Name}, I am a {Title}, {CatchPhrase}");
        }

    }
}
