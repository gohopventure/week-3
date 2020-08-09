using PizzaStore.Domain.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PizzaStore.Storing.Factories
{
    public class MenuFactory : Factory<MenuModel>, IMenuFactory
    {
        public MenuFactory(PizzaStoreDbContext context) : base(context)
        {

        }



        public PizzaStoreDbContext PizzaStoreDbContext
        {
            get { return Context as PizzaStoreDbContext; }
        }
    }
}