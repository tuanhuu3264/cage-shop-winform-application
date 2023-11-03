using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class staff
    {
        public staff()
        {
            Orders = new HashSet<Order>();
            Reports = new HashSet<Report>();
        }

        public string Id { get; set; } = null!;
        public string? Email { get; set; }
        public string? ImageUrl { get; set; }
        public string? Phone { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateWork { get; set; }
        public double? Salary { get; set; }
        public DateTime? DateBirth { get; set; }
        public string? Role { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
