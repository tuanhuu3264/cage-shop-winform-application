using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance = null;
        private CustomerDAO() { }

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDAO();
                }
                return instance;
            }
        }
        public List<Customer> listCustomers()
        {
            using var db = new CAGE_SHOPContext();
            return db.Customers.Include(c => c.Orders).ToList();
        }
        public void insertCustomer(Customer customer)
        {
            using var db = new CAGE_SHOPContext();
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        public void updateCustomer(Customer customer)
        {
            using var db = new CAGE_SHOPContext();
            db.Customers.Update(customer);
            db.SaveChanges();
        }

        public void deteleCustomer(string id)
        {
            using var db = new CAGE_SHOPContext();
            var customer = db.Customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
        }
         public int NumberNewCustomerByMonth(int month, int year)
        {
            var number = listCustomers().Where(m => m.CreateAt != null &&
                                                 m.CreateAt.Value.Month.Equals(month) &&
                                                 m.CreateAt.Value.Year.Equals(year)).Count();
            return number;
        }
    }
}
