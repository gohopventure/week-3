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
                        new domain.CrustModel
                        {
                            Name = "Thin"
                        },
                        new domain.CrustModel
                        {
                            Name = "Pan"
                        },
                        new domain.CrustModel
                        {
                            Name = "Deep Dish"
                        },
                        new domain.CrustModel
                        {
                            Name = "Stuffed"
                        }
                    );
                }

                if(!context.Sizes.Any())
                {
                    context.Sizes.AddRange(
                        new domain.SizeModel
                        {
                            Name = "Personal"
                        },
                        new domain.SizeModel
                        {
                            Name = "Small"
                        },
                        new domain.SizeModel
                        {
                            Name = "Medium"
                        },
                        new domain.SizeModel
                        {
                            Name = "Large"
                        }
                    );
                }

                if(!context.Toppings.Any())
                {
                    context.Toppings.AddRange(
                        new domain.ToppingModel
                        {
                            Name = "Cheese"
                        },
                        new domain.ToppingModel
                        {
                            Name = "Pepperoni"
                        },
                        new domain.ToppingModel
                        {
                            Name = "Sausage"
                        },
                        new domain.ToppingModel
                        {
                            Name = "Chicken"
                        },
                        new domain.ToppingModel
                        {
                            Name = "Onions"
                        },
                        new domain.ToppingModel
                        {
                            Name = "Mushrooms"
                        },
                        new domain.ToppingModel
                        {
                            Name = "Onions"
                        },
                        new domain.ToppingModel
                        {
                            Name = "Bell Peppers"
                        },
                        new domain.ToppingModel
                        {
                            Name = "Olives"
                        }
                    );
                }

                if(!context.Pizzas.Any())
                {
                    var newPizza = new domain.PizzaModel();
                    var newTopping = new domain.ToppingModel();

                    List<ToppingModel> newPizzaTopping = new List<ToppingModel>();
                    newTopping.Name = "Cheese";
                    newPizzaTopping.Add(newTopping);
                    newPizza.Toppings = newPizzaTopping;
                    newPizza.Name = "Cheese";
                    newPizza.Crust = new domain.CrustModel{ Name = "Stuffed" };
                    newPizza.Size = new domain.SizeModel{ Name = "Large" };

                    context.Pizzas.Add(newPizza);
                }

                context.SaveChanges();
            }
        }
    }
}