﻿namespace Jaaf
{
    public interface IFactory<T> where T : class
    {
        T Create();
    }
}
