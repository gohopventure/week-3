using PizzaStore.Domain.Models;
using System.Collections.Generic;

namespace PizzaStore.Domain.Factories
{
    public class PizzaFactory: IFactory<PizzaModel>
    {
        public PizzaModel Create()
        {
            var p = new PizzaModel();

            p.Crust = new CrustModel();
            p.Size = new SizeModel();
            p.Topping = new List<ToppingModel>{ new ToppingModel() };

            return p;
        } 
    }
}