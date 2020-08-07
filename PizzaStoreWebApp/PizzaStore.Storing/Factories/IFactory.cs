using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PizzaStore.Storing.Factories
{
    public interface IFactory<T> where T : class, new()
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(T entities);
    }
}