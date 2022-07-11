using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaDelivery.Models
{
    public class PizzasModel
    {
        public string ImageTitel { get; set; }
        public string Name { get; set; }
        public double BasePrice { get; set; }
        public double FinalPrice { get; set; }
        public bool TomatSouce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Mashrrom { get; set; }
        public bool Pineppel { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }
    }
}
