namespace NET23_Lab6_AmieM_OOPArv
{
    class Program
    {
        static void Main()
        {
            Zoo myZoo = new Zoo();

            Carnivore lion = new Carnivore("Leo", 5, "Savannah");
            Bird parrot = new Bird("Polly", 2);
            Fish goldfish = new Fish("Goldie", 1);

            myZoo.AddAnimal(lion);
            myZoo.AddAnimal(parrot);
            myZoo.AddAnimal(goldfish);

            myZoo.DisplayAnimals();

            lion.MakeSound();
            parrot.MakeSound();
            goldfish.MakeSound();
        }
    }
}