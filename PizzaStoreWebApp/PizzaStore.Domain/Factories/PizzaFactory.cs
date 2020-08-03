using PizzaStore.Domain.Models;
using System.Collections.Generic;

namespace PizzaStore.Domain.Factories
{
    public class PizzaFactory: AFactory<PizzaModel>
    {
        public override PizzaModel CreateMenuItem()
        {
            var p = new PizzaModel();

            p.crust = new CrustModel();
            p.size = new SizeModel();
            p.topping = new List<ToppingModel>{ new ToppingModel() };

            return new PizzaModel();
        } 
    }
}