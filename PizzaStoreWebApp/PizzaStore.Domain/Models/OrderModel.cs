using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class OrderModel : AModel
    {
        public List<PizzaModel> Pizzas { get; set; }
    }
}