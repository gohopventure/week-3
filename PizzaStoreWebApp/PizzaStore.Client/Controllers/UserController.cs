using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;

namespace PizzaStore.Client.Controllers
{
    public class UserController : Controller
    {
        public PizzaStoreDbContext _db;



        public UserController(PizzaStoreDbContext _dbContext)
        {
            _db = _dbContext;
        }



        [HttpGet()]
        public IEnumerable<UserModel> Get()
        {
            return _db.Users.ToList();
        }
        [HttpGet("{id}")]
        public UserModel Get(int id)
        {
            return _db.Users.ToList().SingleOrDefault(u => u.Id == id);
        }
    }
}