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
        public int GetNumberOrderByDay(int day, int month, int year)
        {
            var temp = listOrders().Where(m=> m.DateBuy != null && m.DateBuy.Value.Day.Equals(day)&&m.DateBuy.Value.Month.Equals(month)&&m.DateBuy.Value.Year.Equals(year));
            return temp.Count();
        }
        public int GetNumberOrderByMonth(int month, int year)
        {
            var temp = listOrders().Where(m => m.DateBuy != null && m.DateBuy.Value.Month.Equals(month) && m.DateBuy.Value.Year.Equals(year));
            return temp.Count();
        }
        public int GetNumberOrderByYear(int year)
        {
            var temp = listOrders().Where(m => m.DateBuy != null && m.DateBuy.Value.Year.Equals(year));
            return temp.Count();
        }
        public double GetTotalByDate(int day, int month, int year)
        {
            var temp = listOrders().Where(m => m.DateBuy != null && m.DateBuy.Value.Day.Equals(day) && m.DateBuy.Value.Month.Equals(month) && m.DateBuy.Value.Year.Equals(year)).Sum(m=>m.Total);
            return temp!=null?(double)temp:0;
        }
        public double GetTotalByMonthAndYear(int month, int year)
        {
            var temp = listOrders().Where(m => m.DateBuy != null && m.DateBuy.Value.Month.Equals(month) && m.DateBuy.Value.Year.Equals(year)).Sum(m => m.Total);
            return temp != null ? (double)temp : 0;
        }
        public double GetTotalByYear(int year)
        {
            var temp = listOrders().Where(m => m.DateBuy != null && m.DateBuy.Value.Year.Equals(year)).Sum(m => m.Total);
            return temp != null ? (double)temp : 0;
        }
        public IEnumerable<Object> GetTopTypeProduct(int month, int year)
        {
            throw new NotImplementedException();
        }
    }
}
