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
            Sizes = new SizeFactory(_context);
            Crusts = new CrustFactory(_context);
            Toppings = new ToppingFactory(_context);
            Orders = new OrderFactory(_context);
        }




        public IPizzaFactory Pizzas { get; private set; }
        public ISizeFactory Sizes { get; private set; }
        public ICrustFactory Crusts { get; private set; }
        public IToppingFactory Toppings { get; private set; }
        public IOrderFactory Orders { get; private set; }
        
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