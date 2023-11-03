using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessObject.Models
{
    public partial class OrderProduct
    {
        public string? IdProduct { get; set; }
        public string? IdOrder { get; set; }
        public int? Quantity { get; set; }
        public int? Discount { get; set; }
        public double? Price { get; set; }
        public double? Total { get; set; }

        public virtual Order? IdOrderNavigation { get; set; }
        public virtual Product? IdProductNavigation { get; set; }
    }
}
