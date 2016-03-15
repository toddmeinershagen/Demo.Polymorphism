namespace Demo.Polymorphism
{
    public interface IAdtMapper<T> where T:class
    {
        AdtMessage MapFrom(T value);
    }
}