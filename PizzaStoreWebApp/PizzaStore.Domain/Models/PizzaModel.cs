using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class PizzaModel : AModel
    {
        public SizeModel Size { get; set; } 
        public CrustModel Crust { get; set; }
        // public List<ToppingModel> Toppings { get; set; }
        public decimal Price { get; set; }
        public void ComputePrice()
        {
            Price = Size.Price + Crust.Price;
        }
    }
}