using System;
using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public List<PizzaModel> Pizzas { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; }
        public decimal OrderTotal { get; set; }

        public void ComputeOrderTotal()
        {
            decimal total = 0m; 

            foreach (var p in Pizzas)
            {
                total += p.Price;
            }

            OrderTotal = total;
        }

        public void GetDetails()
        {
            int count = 0;

            foreach (var pizza in Pizzas)
            {
                count += 1;
            }

            Details = $"{count} Item(s)";
        }
    }
}