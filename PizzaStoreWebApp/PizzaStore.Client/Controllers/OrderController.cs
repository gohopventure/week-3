using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PizzaStore.Storing;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client.Controllers
{
    public class OrderController : Controller
    {
        private readonly PizzaStoreDbContext _db;



        public OrderController(PizzaStoreDbContext _dbContext)
        {
            _db = _dbContext;
        }



        
        [HttpGet()]
        public IEnumerable<OrderModel> Get()
        {
            return _db.Orders.ToList();
        }
        [HttpGet("{id}")]
        public OrderModel Get(int id)
        {
            return _db.Orders.ToList().SingleOrDefault(o => o.Id == id);
        }
    }
}