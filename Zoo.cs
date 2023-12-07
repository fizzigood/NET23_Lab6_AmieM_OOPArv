using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET23_Lab6_AmieM_OOPArv
{
    using System;
    using System.Collections.Generic;

    public class Zoo
    {
        // En List som lagrar djuren på Zoo:
        private List<Animal> animals;

        // Constructor:
        public Zoo()
        {
            animals = new List<Animal>();
        }

        // En metod som lägger till djur till Zoo:
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            Console.WriteLine($"{animal.Name} has been added to the zoo.");
        }

        // En metod som tar bort djur från Zoo:
        public void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
            Console.WriteLine($"{animal.Name} has been removed from the zoo.");
        }

        // Metod som visar djuren på Zoo:
        public void DisplayAnimals()
        {
            Console.WriteLine("Animals in the zoo:");
            foreach (var animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}, Habitat: {animal.Habitat}");
            }
        }
    }

}
