using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class TypeProduct
    {
        public TypeProduct()
        {
            Products = new HashSet<Product>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
