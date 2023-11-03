using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Order
    {
        public string Id { get; set; } = null!;
        public DateTime? DateBuy { get; set; }
        public double? Total { get; set; }
        public string? IdCustomer { get; set; }
        public string? IdStaff { get; set; }

        public virtual Customer? IdCustomerNavigation { get; set; }
        public virtual staff? IdStaffNavigation { get; set; }
    }
}
