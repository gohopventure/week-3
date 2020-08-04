using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PizzaStore.Storing;
using PizzaStore.Domain.Models;
using PizzaStore.Client.Models;
using PizzaStore.Domain.Factories;

namespace PizzaStore.Client.Controllers
{
    public class OrderController : Controller
    {
        private readonly PizzaStoreDbContext _db;




        public OrderController(PizzaStoreDbContext _dbContext)
        {
            _db = _dbContext;
        }



        
        [HttpGet()] // This is the default request
        public IActionResult Home()
        {
            return View("Order", new PizzaViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PlaceOrder(PizzaViewModel pizzaViewModel) // model binding
        {
            if (ModelState.IsValid)
            {
                var p = new PizzaFactory();
                // repository.CreateOrder(pizzaViewModel); // once a valid order is placed
                return View();
            }
            return View("Order", pizzaViewModel);
        }
    }
}