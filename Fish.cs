using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET23_Lab6_AmieM_OOPArv
{
    public class Fish : Animal
    {
        // Egen egenskap för Fish:
        public string FinColor { get; set; }

        // Constructor:
        public Fish(string name, int age) : base(name, age, "Blub", "Water", "Those shiny sprinkles")
        {
            FinColor = "Silver"; // Defaultvärde
        }

        // Egen metod för Fish:
        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming in water.");
        }
    }
}
