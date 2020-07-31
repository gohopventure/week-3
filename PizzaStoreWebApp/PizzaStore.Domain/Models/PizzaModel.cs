using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class PizzaModel : AModel
    {
        public SizeModel size { get; set; } 
        public CrustModel crust { get; set; }
        public List<ToppingModel> topping { get; set; }
    }
}