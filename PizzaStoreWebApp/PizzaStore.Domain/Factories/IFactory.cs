using System.Collections.Generic;

namespace PizzaStore.Domain.Factories
{
    public interface IFactory<T> where T : class, new()
    {
        T CreateMenuItem();
        T CreateSpecialtyItems();
    }
}