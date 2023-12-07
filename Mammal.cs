using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET23_Lab6_AmieM_OOPArv
{
    public class Mammal : Animal
    {   
        // Egen egenskap för Mammal:
        public string FurColor { get; set; }


        // Constructor:
        public Mammal(string name, int age, string habitat) : base(name, age, "Sneeze", habitat, "Football")
        {
            FurColor = "Brown"; 
        }

        // En egen metod för Mammal:
        public void GiveBirth()
        {
            Console.WriteLine($"{Name} gives birth to offspring.");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} walks around on four legs.");
        }
    }


    public class Herbivore : Mammal
    {

        public string PreferredFood { get; set; }

        // Constructor:
        public Herbivore(string name, int age, string habitat) : base(name, age, habitat)
        {
            PreferredFood = "Grass"; // Defaultvärde 
        }

        // En egen metod för Herbivore:
        public void Graze()
        {
            Console.WriteLine($"{Name} is peacefully grazing on {PreferredFood}.");
        }

        // Override av Move från basklassen:
        public override void Move()
        {
            Console.WriteLine($"{Name} walks on four legs and grazes.");
        }
    }

    public class Carnivore : Mammal
    {
        // Egen egenskap för Carnivore:
        public string Prey { get; set; }

        // Constructor:
        public Carnivore(string name, int age, string habitat) : base(name, age, habitat)
        {
            Prey = "No specific prey"; // Defaultvärde 
        }

        // Egen metod för Carnivore:
        public void Hunt()
        {
            Console.WriteLine($"{Name} is hunting for {Prey}.");
        }

        // Override av MakeSound från basklassen:
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} growls menacingly.");
        }
    }

}
