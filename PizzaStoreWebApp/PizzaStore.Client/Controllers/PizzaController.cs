using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PizzaStore.Storing;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client.Controllers
{
    public class PizzaController : Controller
    {
        private readonly PizzaStoreDbContext _db;





        public PizzaController(PizzaStoreDbContext _dbContext)
        {
            _db = _dbContext;
        }



        [HttpGet()]
        public IActionResult Get()
        {
            // ViewData, and TempData are dictionaries, while ViewBag is a dynamic object
            // ViewData, and ViewBag are temporary, only survive the view, while TempData survives after the view is dismissed
            ViewBag.PizzaList = _db.Pizzas.ToList();

            // var DummyViewBag = new object(); // strongly-typed, type cannot be changed based on value as seen below

            // DummyViewBag = 3; // will cause an error in build

            // dynamic DummyViewBag2 = 10; // dynamically-typed, allows for type changes based on value given as seen below

            // DummyViewBag2 = new object();
            // DummyViewBag2 = 'b';
            // DummyViewBag2.PizzaList = _db.Pizzas.ToList();

            return View("Home2", _db.Pizzas.ToList());
        }
        [HttpGet("{id}")]
        public PizzaModel Get(int id) 
        {
            return _db.Pizzas.ToList().SingleOrDefault(p => p.Id == id);
        }
    }
}