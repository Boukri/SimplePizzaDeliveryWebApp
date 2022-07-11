using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaDelivery.Models;

namespace PizzaDelivery.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; } = new PizzasModel();
        public double FinalPrice { get; set; }
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            Pizza.BasePrice = 700;
            FinalPrice = Pizza.BasePrice;
            if (Pizza.TomatSouce) FinalPrice += 50;
            if (Pizza.Cheese) FinalPrice += 150;
            if (Pizza.Beef) FinalPrice += 250;
            if (Pizza.Ham) FinalPrice += 70;
            if (Pizza.Mashrrom) FinalPrice += 350;
            if (Pizza.Peperoni) FinalPrice += 150;
            if (Pizza.Pineppel) FinalPrice += 450;
            return RedirectToPage("/Checkout/Chekcout", new { Pizza.Name, FinalPrice});
        }
    }
}
