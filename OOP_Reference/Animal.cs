using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Reference
{
    internal class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("animal noise");
        }

        public virtual void Nap()
        {
            Console.WriteLine("zzz.. zzz..");
        }

    }
}
