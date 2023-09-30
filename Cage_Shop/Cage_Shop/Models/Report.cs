using Cage_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cage_Shop.Models
{
    internal class Report
    {
        private string id { set; get; }
        private string content { set; get; }
        private string title { set; get; }
        private Staff staff { set; get; }

        public Report(string id, string content, string title, Staff staff)
        {
            this.id = id;
            this.content = content;
            this.title = title;
            this.staff = staff;
        }
    }
}
