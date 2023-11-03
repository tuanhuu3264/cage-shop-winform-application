using BusinessObject.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDAO
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private OrderDAO() { }

        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                }
                return instance;
            }
        }
        public List<Order> listOrders()
        {
            using var db = new CAGE_SHOPContext();
            var temp = db.Orders.Include(c => c.IdCustomerNavigation).Include(c => c.IdStaffNavigation).ToList();
            return temp;
        }
        public bool checkIdOrder(string id)
        {
            var temp = listOrders().FirstOrDefault(m => m.Id == id);
            if(temp != null)
            {
                return true;
            }
            return false;
        }
        public void insertOrder(Order order)
        {
            using var db = new CAGE_SHOPContext();
            db.Orders.Add(order);
            db.SaveChanges();
        }
        public void updateTotalOrder(double newTotal, string id)
        {
            using var db = new CAGE_SHOPContext();
            var temp = db.Orders.FirstOrDefault(m => m.Id == id);
            if(temp != null)
            {
                temp.Total = newTotal;
                db.SaveChanges();
            }
        }
        public void deleteOrder(string id)
        {
            using var db = new CAGE_SHOPContext();
            var temp = listOrders().FirstOrDefault(m => m.Id == id);
            if(temp != null)
            {
                db.Orders.Remove(temp);
                db.SaveChanges();
            }
        }
    }
}
