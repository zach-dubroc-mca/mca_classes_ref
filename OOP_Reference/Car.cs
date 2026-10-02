using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Reference
{
    internal class Car
    {
        //Car Data
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get;  private set; }

        //constructor: sets the default values for an object
        //object: an instance of a class when it's first created
        public Car(string make, string model) {
            Make = make;
            Model = model;
            Speed = 0;
        }//end constructor

        public void Accelerate(int mph)
        {
            Speed += mph;
            Console.WriteLine($"this {Make} {Model} is going {Speed}MPH");
        }
        public void Brake(int mph)
        {
            Speed -= mph;
            if (Speed < 0)
            {
                Speed = 0;
            }
            Console.WriteLine($"this {Make} {Model} is going {Speed}MPH");
        }
    }
}
