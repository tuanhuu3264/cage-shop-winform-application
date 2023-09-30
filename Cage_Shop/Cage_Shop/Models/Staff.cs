using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cage_Shop.Model
{
    internal class Staff
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string ImageUrl { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime DateWork { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateBirth { get; set; }

        public Staff()
        {
        }
        public Staff(
            string id,
            string email,
            string role,
            string imageUrl,
            string phone,
            string name,
            string address,
            string gender,
            DateTime dateWork,
            decimal salary,
            DateTime dateBirth)
        {
            Id = id;
            Email = email;
            Role = role;
            ImageUrl = imageUrl;
            Phone = phone;
            Name = name;
            Address = address;
            Gender = gender;
            DateWork = dateWork;
            Salary = salary;
            DateBirth = dateBirth;
        }
    }
}
