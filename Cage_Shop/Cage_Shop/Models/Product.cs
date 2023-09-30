using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cage_Shop.Model
{
    internal class Product
    {
        public Product(string id, string name, string type, double price, int quantity, string description, string material)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.price = price;
            this.quantity = quantity;
            this.description = description;
            this.material = material;
        }

        private string id { get; set; }
        private string name { get; set; }
        private string type { get; set; }
        private double price { set; get; }
        private int quantity { set; get; }
        private string description { get; set; }
        private string material { set; get; }
    }
}
