using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
               public class Pet
        {
            public string type;
            public string name;
            public string owner;
            public double weight;

            Pet pet1 = new Pet("dog", "Shadow", "Jose", 42.6);

            //This will fill inform the user on the pets name and weight
            Console.WriteLine("Name: " + pet1.name);
            Console.WriteLine("Weight: " + pet1.weight);
            Console.WriteLine(pet1.getTag());

            Console.WriteLine("");

            Dog dog1 = new Dog("Daisy", "Kent", 23.4);
            //Displays dog 1 info
            Console.WriteLine("Name: " + dog1.name);
            Console.WriteLine("Weight: " + dog1.weight);
            Console.WriteLine(dog1.getTag());
            Console.WriteLine(dog1.bark(4));

            Console.WriteLine("");

            Cat cat1 = new Cat("Simba", "Maria", 5.2);
            //Displays cats info
            Console.WriteLine("Name: " + cat1.name);
            Console.WriteLine("Weight: " + cat1.weight);
            Console.WriteLine(cat1.getTag());
            Console.WriteLine(cat1.meow(3));
        }
    }
}
