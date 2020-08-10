using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PizzaStore.Storing;
using PizzaStore.Domain.Models;
using PizzaStore.Client.Models;
using PizzaStore.Storing.Factories;
using PizzaStore.Exchange.Concierge;
using System;

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



        
        // [HttpGet()]
        public IActionResult Orders()
        {
            UnitOfWork unitOfWork = new UnitOfWork(_db);

            ViewBag.Orders = unitOfWork.Orders.GetAll();

            return View("Orders");
        
        }
        
        public IActionResult OrderDetails()
        {
            UnitOfWork unitOfWork = new UnitOfWork(_db);

            ViewBag.Pizzas = unitOfWork.Pizzas.GetAll();

            return View("OrderDetails");
        }

        // [HttpGet()]
        public IActionResult AddPizza()
        {
            UnitOfWork unitOfWork = new UnitOfWork(_db);

            ViewBag.MenuItems = unitOfWork.MenuItems.GetAll();
            ViewBag.Sizes = unitOfWork.Sizes.GetAll();
            ViewBag.Crusts = unitOfWork.Crusts.GetAll();
            ViewBag.Toppings = unitOfWork.Toppings.GetAll();

            return View("AddPizza", new PizzaViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PlaceOrder(PizzaViewModel model) // model binding
        {
            UnitOfWork unitOfWork = new UnitOfWork(_db);

            ViewBag.MenuItems = unitOfWork.MenuItems.GetAll();
            ViewBag.Sizes = unitOfWork.Sizes.GetAll();
            ViewBag.Crusts = unitOfWork.Crusts.GetAll();
            ViewBag.Toppings = unitOfWork.Toppings.GetAll();

            if (ModelState.IsValid)
            {
                var size = unitOfWork.Sizes.Find(s => s.Name == model.Size).FirstOrDefault();
                var crust = unitOfWork.Crusts.Find(c => c.Name == model.Crust).FirstOrDefault();
                var pizza = new PizzaModel{ Name = model.MenuItems, Size = size, Crust = crust };

                pizza.ComputePrice();

                List<PizzaModel> pizzas = new List<PizzaModel>();
                pizzas.Add( pizza );

                OrderModel order = new OrderModel();
                order.Pizzas = pizzas;
                order.ComputeOrderTotal();
                order.GetDetails();
                order.Date = DateTime.Now;

                unitOfWork.Orders.Add(order); 
                unitOfWork.Complete();
                unitOfWork.Dispose();

                return RedirectToAction("Orders");
            }
            
            return View("AddPizza", model);
        }
    }
}