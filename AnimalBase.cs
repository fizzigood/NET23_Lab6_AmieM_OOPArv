using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET23_Lab6_AmieM_OOPArv
{
    public class Animal
    {
        //Fem egenskaper som alla djur delar med varandra:
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sound { get; set; }
        public string Habitat { get; set; }
        public string FavThing { get; set; }


        //Constructor:
        public Animal(string name, int age, string sound, string habitat, string favThing)
        {
            Name = name;
            Age = age;
            Sound = sound;
            Habitat = habitat;
            FavThing = favThing;
        }

        // Tre metoder som alla djur delar med varandra, varav en är MakeSound():
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says: {Sound}");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name} moves around.");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }
}
