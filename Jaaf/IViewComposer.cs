namespace Jaaf
{
    public interface IViewComposer<T>
    {
        T Compose();
        T Compose(int id);
    }
}