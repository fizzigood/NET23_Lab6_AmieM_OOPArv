using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET23_Lab6_AmieM_OOPArv
{
    public class Bird : Animal
    {
        // Egen egenskap för Bird
        public double Wingspan { get; set; }

        // Constructor:
        public Bird(string name, int age) : base(name, age, "Tweet", "Sky", "Nuts and seeds")
        {
            Wingspan = 1.0; // Defaultvärde
        }

        // Egen metod för Bird
        public void BuildNest()
        {
            Console.WriteLine($"{Name} is building a nest.");
        }

        // Override av Sleep från basklassen:
        public override void Sleep()
        {
            Console.WriteLine($"{Name} sleeps on a perch.");
        }
    }
}
