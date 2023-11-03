using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Product
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public double? PriceImport { get; set; }
        public double? PriceExport { get; set; }
        public int? Quantity { get; set; }
        public string? Description { get; set; }
        public string? IdTypeProduct { get; set; }

        public virtual TypeProduct? IdTypeProductNavigation { get; set; }
    }
}
