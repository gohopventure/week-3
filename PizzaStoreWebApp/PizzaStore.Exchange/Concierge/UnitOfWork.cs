using System;
using PizzaStore.Storing;
using PizzaStore.Storing.Factories;

namespace PizzaStore.Exchange.Concierge
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PizzaStoreDbContext _context;




        public UnitOfWork(PizzaStoreDbContext context)
        {
            _context = context;
            Pizzas = new PizzaFactory(_context);
        }




        public IPizzaFactory Pizzas { get; private set; }

        IPizzaFactory IUnitOfWork.Pizzas => throw new NotImplementedException();

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}