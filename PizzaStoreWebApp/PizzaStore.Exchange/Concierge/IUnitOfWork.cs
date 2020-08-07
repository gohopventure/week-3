using System;
using PizzaStore.Storing.Factories;

namespace PizzaStore.Exchange.Concierge
{
    public interface IUnitOfWork : IDisposable
    {
        IPizzaFactory Pizzas { get; }
        ISizeFactory Sizes { get; }
        ICrustFactory Crusts { get; }
        IToppingFactory Toppings { get; }
        int Complete();
    }
}