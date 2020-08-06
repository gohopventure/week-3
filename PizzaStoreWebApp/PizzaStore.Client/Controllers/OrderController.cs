using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PizzaStore.Storing;
using PizzaStore.Domain.Models;
using PizzaStore.Client.Models;
using PizzaStore.Domain.Factories;

namespace PizzaStore.Client.Controllers
{
    // [Route("/Order/{id=1}")] // controller routing
    // [EnableCors("private")]
    public class OrderController : Controller
    {
        private readonly PizzaStoreDbContext _db;




        public OrderController(PizzaStoreDbContext _dbContext)
        {
            _db = _dbContext;
        }



        
        // [HttpGet()] // This is the default request
        public IActionResult Get(int id)
        {
            switch(id)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
            return View("Order", new PizzaViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PlaceOrder(PizzaViewModel pizzaViewModel) // model binding
        {
            if (ModelState.IsValid)
            {
                var p = new PizzaFactory();
                // p.Create();
                // repository.CreateOrder(pizzaViewModel); // once a valid order is placed
                // return View("User"); // or 
                return Redirect("/User/index"); // http 300-series status
            }
            return View("Order", pizzaViewModel);
        }
    }
}