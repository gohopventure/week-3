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




        public IEnumerable<PizzaModel> Get()
        {
            return _db.Pizzas.ToList();
        }
        public PizzaModel Get(int id)
        {
            return _db.Pizzas.ToList().SingleOrDefault(p => p.Id == id);
        }
    }
}