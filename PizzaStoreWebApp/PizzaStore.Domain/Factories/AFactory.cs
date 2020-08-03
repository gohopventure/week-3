using System.Collections.Generic;

namespace PizzaStore.Domain.Factories
{
    public abstract class AFactory<T> where T : class, new()
    {
        public virtual T CreateMenuItem()
        {
            return new T();
        }
        public virtual T CreateSpecialtyItems()
        {
            return new T();
        }
    }
}