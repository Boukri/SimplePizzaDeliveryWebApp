using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaDelivery.Pages
{
    public class PizzaModel : PageModel
    {
        [BindProperty]
        public List<Models.PizzasModel> PizzaList { get; set; } = new List<Models.PizzasModel>()
        {
            new Models.PizzasModel()
            {
                ImageTitel = "Margerita",
                Name = "Margerita",
                BasePrice = 700,
                FinalPrice = 700,
                TomatSouce = true,
                Cheese = true
            },
            new Models.PizzasModel()
            {
                ImageTitel = "Bolognese",
                Name = "Bolognese",
                BasePrice = 900, 
                FinalPrice = 900,
                TomatSouce = true,
                Cheese = true
            },
            new Models.PizzasModel()
            {
                ImageTitel = "Carbonara",
                Name = "Carbonara",
                BasePrice = 1100, FinalPrice = 1100,
                TomatSouce = true,
                Cheese = true
            },
            new Models.PizzasModel()
            {
                ImageTitel = "Hawaiian",
                Name = "Hawaiian",
                BasePrice = 1300, FinalPrice = 1300,
                TomatSouce = true,
                Cheese = true
            },
            new Models.PizzasModel()
            {
                ImageTitel = "MeatFeast",
                Name = "MeatFeast",
                BasePrice = 1500, FinalPrice = 1500,
                TomatSouce = true,
                Cheese = true
            },
            new Models.PizzasModel()
            {
                ImageTitel = "Mushroom",
                Name = "Mushroom",
                BasePrice = 1750, FinalPrice = 1750,
                TomatSouce = true,
                Cheese = true
            },
            new Models.PizzasModel()
            {
                ImageTitel = "Pepperoni",
                Name = "Pepperoni",
                BasePrice = 1700, FinalPrice = 1700,
                TomatSouce = true,
                Cheese = true
            },
            new Models.PizzasModel()
            {
                ImageTitel = "Seafood",
                Name = "Seafood",
                BasePrice = 2700, FinalPrice = 2700,
                TomatSouce = true,
                Cheese = true
            },
            new Models.PizzasModel()
            {
                ImageTitel = "Vegetarian",
                Name = "Vegetarian",
                BasePrice = 600, FinalPrice = 600,
                TomatSouce = true,
                Cheese = true
            },
        };
        public void OnGet()
        {
        }
    }
}
