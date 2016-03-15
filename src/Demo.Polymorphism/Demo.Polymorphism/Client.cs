using System.Diagnostics;

namespace Demo.Polymorphism
{
    public class Client
    {
        public AdtMessage Execute<T>(T value) where T:class
        {
            IAdtMapper<T> mapper;

            switch (value.GetType().FullName)
            {
                case "Demo.Polymorphism.Dogs.Dog":
                    mapper = new DogAdtMapper() as IAdtMapper<T>;
                    break;
                default:
                    mapper = new CatAdtMapper() as IAdtMapper<T>;
                    break;
            }

            return mapper.MapFrom(value);
        }

        public T Map<T>(string rawHL7) where T:class
        {
            IMapper<T> mapper;

            switch (typeof(T).FullName)
            {
                case "Demo.Polymorphism.Dogs.Dog":
                    mapper = new DogMapper() as IMapper<T>;
                    break;
                default:
                    mapper = new CatMapper() as IMapper<T>;
                    break;
            }

            return mapper.MapFrom(rawHL7);
        }
    }
}