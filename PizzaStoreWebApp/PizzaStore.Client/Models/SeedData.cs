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
                if(!context.Crusts.Any())
                {
                    context.Crusts.AddRange(
                        new domain.CrustModel{ Name = "Thin" },
                        new domain.CrustModel{ Name = "Pan" },
                        new domain.CrustModel{ Name = "Deep Dish" },
                        new domain.CrustModel{ Name = "Stuffed" }
                    );
                }

                if(!context.Sizes.Any())
                {
                    context.Sizes.AddRange(
                        new domain.SizeModel{ Name = "Personal" },
                        new domain.SizeModel{ Name = "Small" },
                        new domain.SizeModel{ Name = "Medium" },
                        new domain.SizeModel{ Name = "Large" }
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