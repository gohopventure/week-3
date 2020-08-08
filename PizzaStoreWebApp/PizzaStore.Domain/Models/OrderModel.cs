using System;
using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class OrderModel : AModel
    {
        public List<PizzaModel> Pizzas { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; }
        public decimal OrderTotal { get; set; }
    }
}