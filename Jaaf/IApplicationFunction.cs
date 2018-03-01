namespace Jaaf
{
    public interface IApplicationFunction<T>
    {
        void Run(T message);
    }
}
