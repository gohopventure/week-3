using System.Collections.Generic;
using PizzaStore.Domain.Models;
using PizzaStore.Domain.Factories;
using System.ComponentModel.DataAnnotations;

namespace PizzaStore.Client.Models
{
    public class PizzaViewModel
    {
        public List<CrustModel> Crusts { get; set; }
        public List<SizeModel> Sizes { get; set; }
        public List<ToppingModel> Toppings { get; set; }



        
        public PizzaViewModel()
        {
            // TODO: Instantiate PVModel in order to overcome nullpointerreference
            Crusts = new List<CrustModel>() { new CrustModel() { Name = "Chicago" } };
            Sizes = new List<SizeModel>() { new SizeModel() { Name = "Medium" } };
            Toppings = new List<ToppingModel>() { new ToppingModel() { Name = "Pepperoni" } };
        }




        [Required]
        public CrustModel Crust { get; set; }
        [Required]
        public SizeModel Size { get; set; }
        [Range(2,5)]
        public List<ToppingModel> SelectedToppings { get; set; }
        public bool SelectedTopping { get; set; }
    }
}