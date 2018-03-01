using System;
using System.Collections.Generic;
using System.Text;

namespace Jaaf
{
    public interface IExecutionResult<T>
    {
        bool Success { get; }
        T Result { get; }
    }
}
