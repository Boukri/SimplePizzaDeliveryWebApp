using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaDelivery.Pages.Checkout
{
    [BindProperties (SupportsGet = true)]
    public class ChekcoutModel : PageModel
    {
        
        public string Name { get; set; }
        public double FinalPrice { get; set; }
        public string ImageTitel { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrEmpty(Name))
            {
                Name = "Custom pizza";
            }
            if (string.IsNullOrEmpty(ImageTitel))
            {
                ImageTitel = "Create";
            }
        }
    }
}
