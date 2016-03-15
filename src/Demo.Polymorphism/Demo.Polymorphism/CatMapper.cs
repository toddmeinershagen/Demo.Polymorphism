using System;

using Demo.Polymorphism.Cats;

namespace Demo.Polymorphism
{
    public class CatMapper : IMapper<Cat>
    {
        public Cat MapFrom(string rawHL7)
        {
            Console.WriteLine("CatMapper...");
            return null;
        }
    }
}