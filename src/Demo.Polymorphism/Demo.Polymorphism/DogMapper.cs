using System;

using Demo.Polymorphism.Dogs;

namespace Demo.Polymorphism
{
    public class DogMapper : IMapper<Dog>
    {
        public Dog MapFrom(string rawHL7)
        {
            Console.WriteLine("DogMapper...");
            return null;
        }
    }
}