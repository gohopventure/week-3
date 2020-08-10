using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using domain = PizzaStore.Domain.Models;
using PizzaStore.Storing;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new PizzaStoreDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<PizzaStoreDbContext>>()))
            {
                if(!context.Users.Any())
                {
                    context.Users.AddRange(
                        new domain.UserModel{ Name = "Harry" }
                    );
                }

                if(!context.Stores.Any())
                {
                    context.Stores.AddRange(
                        new domain.StoreModel{ Name = "Store1" },
                        new domain.StoreModel{ Name = "Store2" }
                    );
                }

                if(!context.Crusts.Any())
                {
                    context.Crusts.AddRange(
                        new domain.CrustModel{ Name = "Thin", Price = 0.99m  },
                        new domain.CrustModel{ Name = "Pan", Price = 1.99m  },
                        new domain.CrustModel{ Name = "Deep Dish", Price = 2.99m  },
                        new domain.CrustModel{ Name = "Stuffed", Price = 3.99m  }
                    );
                }

                if(!context.Sizes.Any())
                {
                    context.Sizes.AddRange(
                        new domain.SizeModel{ Name = "Personal", Price = 2.99m },
                        new domain.SizeModel{ Name = "Small", Price = 3.99m  },
                        new domain.SizeModel{ Name = "Medium", Price = 5.99m  },
                        new domain.SizeModel{ Name = "Large", Price = 7.99m  }
                    );
                }

                if(!context.Toppings.Any())
                {
                    context.Toppings.AddRange(
                        new domain.ToppingModel{ Name = "Cheese" },
                        new domain.ToppingModel{ Name = "Pepperoni" },
                        new domain.ToppingModel{ Name = "Sausage" },
                        new domain.ToppingModel{ Name = "Chicken" },
                        new domain.ToppingModel{ Name = "Onions" },
                        new domain.ToppingModel{ Name = "Mushrooms" },
                        new domain.ToppingModel{ Name = "Bell Peppers" },
                        new domain.ToppingModel{ Name = "Olives" }
                    );
                }

                if(!context.MenuItems.Any())
                {

                    context.MenuItems.AddRange(
                        new domain.MenuModel{ Name = "Cheese", isSpecialtyItem = false },
                        new domain.MenuModel{ Name = "Pepperoni", isSpecialtyItem = false },
                        new domain.MenuModel{ Name = "Sausage", isSpecialtyItem = false },
                        new domain.MenuModel{ Name = "Chicken", isSpecialtyItem = false },
                        new domain.MenuModel{ Name = "Supreme", isSpecialtyItem = false },
                        new domain.MenuModel{ Name = "Meat Lover", isSpecialtyItem = false },
                        new domain.MenuModel{ Name = "Veggie", isSpecialtyItem = false },
                        new domain.MenuModel{ Name = "Custom", isSpecialtyItem = true }
                    );
                }

                context.SaveChanges();
            }
        }
    }
}