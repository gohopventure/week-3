using System;
using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        // public List<PizzaModel> Pizzas { get; set; }
        public DateTime Date { get; set; }
        // public string Details { get; set; }
        // public decimal OrderTotal { get; set; }
    }
}