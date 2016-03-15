using System;

using Demo.Polymorphism.Cats;

namespace Demo.Polymorphism
{
    public class CatAdtMapper : IAdtMapper<Cat>
    {
        public AdtMessage MapFrom(Cat value)
        {
            Console.WriteLine("You went through the CatAdtMapper.");
            return null;
        }
    }
}