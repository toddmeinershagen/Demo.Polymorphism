using System;

using Demo.Polymorphism.Dogs;

namespace Demo.Polymorphism
{
    public class DogAdtMapper : IAdtMapper<Dog>
    {
        public AdtMessage MapFrom(Dog value)
        {
            Console.WriteLine("You went through the DogAdtMapper.");
            return null;
        }
    }
}