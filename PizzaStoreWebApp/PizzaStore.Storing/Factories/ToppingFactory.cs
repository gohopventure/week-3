using PizzaStore.Domain.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PizzaStore.Storing.Factories
{
    public class ToppingFactory : Factory<ToppingModel>, IToppingFactory
    {
        public ToppingFactory(PizzaStoreDbContext context) : base(context)
        {

        }



        public PizzaStoreDbContext PizzaStoreDbContext
        {
            get { return Context as PizzaStoreDbContext; }
        }
    }
}