using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class PizzaModel : AModel
    {
        public SizeModel Size { get; set; } 
        public CrustModel Crust { get; set; }
        public List<ToppingModel> Topping { get; set; }
    }
}