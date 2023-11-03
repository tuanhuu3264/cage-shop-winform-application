using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Report
    {
        public string Id { get; set; } = null!;
        public string? Content { get; set; }
        public string? Title { get; set; }
        public string? IdStaff { get; set; }

        public virtual staff? IdStaffNavigation { get; set; }
    }
}
