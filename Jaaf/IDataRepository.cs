using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Jaaf
{
    public interface IDataRepository<T> where T : class
    {
        IEnumerable<T> Fetch();
        IEnumerable<T> Fetch(params string[] includes);
        T Fetch(int id);
        T Fetch(int id, params string[] includes);
        int Delete(int id);
        T Update(T entity);
        IEnumerable<T> AddRange(IEnumerable<T> entities);
        IQueryable<T> Where(Expression<Func<T, bool>> filter);
        IQueryable<T> Where(Expression<Func<T, bool>> filter, params string[] includes);
    }
}
