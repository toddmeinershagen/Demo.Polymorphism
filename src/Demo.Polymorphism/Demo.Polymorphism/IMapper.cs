namespace Demo.Polymorphism
{
    public interface IMapper<T> where T : class
    {
        T MapFrom(string rawHL7);
    }
}