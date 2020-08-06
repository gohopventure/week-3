// using System.Collections.Generic;
// using Microsoft.AspNetCore.Mvc;
// using System.Linq;
// using PizzaStore.Storing;
// using PizzaStore.Domain.Models;

// namespace PizzaStore.Client.Controllers
// {
//     public class StoreController : Controller
//     {
//         public PizzaStoreDbContext _db;



//         public StoreController(PizzaStoreDbContext _dbContext)
//         {
//             _db = _dbContext;
//         }



//         [HttpGet()]
//         public IEnumerable<StoreModel> Get()
//         {
//             return _db.Stores.ToList();
//         }
//         [HttpGet("{id}")]
//         public StoreModel Get(int id)
//         {
//             return _db.Stores.ToList().SingleOrDefault(s => s.Id == id);
//         }
//     }
// }