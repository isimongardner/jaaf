namespace Jaaf
{
    public interface IApplicationCommand<E, R> 
                        where E : IExecutionResult<E> 
                            where R : IApplicationRequest
    {
        E Execute(R request);
    }
}
