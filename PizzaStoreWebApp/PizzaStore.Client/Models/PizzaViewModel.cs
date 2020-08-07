using System.Collections.Generic;
using PizzaStore.Domain.Models;
using PizzaStore.Storing.Factories;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace PizzaStore.Client.Models
{
    public class PizzaViewModel
    {
        // out to client
        public List<CrustModel> Crusts { get; set; }
        public List<SizeModel> Sizes { get; set; }
        public List<ToppingModel> Toppings { get; set; }



        
        public PizzaViewModel()
        {
            Crusts = new List<CrustModel>();
            Crusts.Add(new CrustModel{ Name = "Thin" });
            Crusts.Add(new CrustModel{ Name = "Deep Dish" });
            Crusts.Add(new CrustModel{ Name = "Pan" });
            Crusts.Add(new CrustModel{ Name = "Stuffed" });

            Sizes = new List<SizeModel>();
            Sizes.Add(new SizeModel{ Name = "Personal" });
            Sizes.Add(new SizeModel{ Name = "Small" });
            Sizes.Add(new SizeModel{ Name = "Medium" });
            Sizes.Add(new SizeModel{ Name = "Large" });

            Toppings = new List<ToppingModel>();
            Toppings.Add(new ToppingModel{ Name = "Cheese" });
            Toppings.Add(new ToppingModel{ Name = "Pepperoni" });
            Toppings.Add(new ToppingModel{ Name = "Sausage" });
            Toppings.Add(new ToppingModel{ Name = "Chicken" });
            Toppings.Add(new ToppingModel{ Name = "Onions" });
            Toppings.Add(new ToppingModel{ Name = "Mushrooms" });
            Toppings.Add(new ToppingModel{ Name = "Bell Peppers" });
            Toppings.Add(new ToppingModel{ Name = "Olives" });
        }




        // in from client
        [Required(ErrorMessage = "Please select a crust")]
        public string Crust { get; set; }
        [Required(ErrorMessage = "Please select a size")]
        public string Size { get; set; }
        [DisplayName("Toppings")]
        [Required(ErrorMessage = "Please select at least two toppings")]
        [MinLength(_min_toppings, ErrorMessage = "Please select a minimum of {1} toppings")]
        [MaxLength(_max_toppings, ErrorMessage = "Please select a maximum of {1} toppings")]
        public List<string> SelectedToppings { get; set; }
        // public bool SelectedTopping { get; set; }

        public const int _min_toppings = 2;
        public const int _max_toppings = 5;
    }
}