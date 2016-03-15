using System;
using System.Collections.Generic;
using System.ComponentModel;

using Demo.Polymorphism.Cats;
using Demo.Polymorphism.Dogs;

namespace Demo.Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<dynamic> {new Cat("Todd"), new Dog("James")};

            foreach (var animal in animals)
            {
                DisplayName(animal);
            }

            Console.ReadLine();

            var client = new Client();
            const string hl7 = "hl7";

            var dog = new Dog("Todd Meinershagen");
            client.Execute(dog);
            client.Map<Dog>(hl7);

            var cat = new Cat("Todd Meinershagen");
            client.Execute(cat);
            client.Map<Cat>(hl7);

            Console.ReadLine();
        }

        public static void DisplayName(dynamic animal)
        {
            Console.WriteLine($"Hi, {animal.Name}");
        }
    }
}
