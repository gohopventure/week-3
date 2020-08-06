using PizzaStore.Domain.Models;
using System.Collections.Generic;

namespace PizzaStore.Domain.Factories
{
    public class PizzaFactory: IFactory<PizzaModel>
    {
        public PizzaModel Create()
        {
            var p = new PizzaModel();

            p.crust = new CrustModel();
            p.size = new SizeModel();
            p.topping = new List<ToppingModel>{ new ToppingModel() };

            return p;
        } 
    }
}