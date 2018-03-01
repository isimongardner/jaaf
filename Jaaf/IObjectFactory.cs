namespace Jaaf
{
    public interface IObjectFactory<T> where T : class
    {
        T Create();
    }
}
