using BusinessObject.Models;
using HRMDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMRepositories
{
    public class OrderRepositories : IOrderRepositories
    {
        public bool checkIdOrder(string id)
        => OrderDAO.Instance.checkIdOrder(id);

        public void deleteOrder(string id)
        => OrderDAO.Instance.deleteOrder(id);

        public int GetNumberOrderByDay(int day, int month, int year)=>OrderDAO.Instance.GetNumberOrderByDay(day, month, year);

        public int GetNumberOrderByMonth(int month, int year)=>OrderDAO.Instance.GetNumberOrderByMonth(month, year);

        public int GetNumberOrderByYear(int year) => OrderDAO.Instance.GetNumberOrderByYear(year);

        public IEnumerable<object> GetTopTypeProduct(int month, int year)
        {
            throw new NotImplementedException();
        }

        public double GetTotalByDate(int day, int month, int year)=>OrderDAO.Instance.GetTotalByDate(day, month, year);

        public double GetTotalByMonthAndYear(int month, int year)=>OrderDAO.Instance.GetTotalByMonthAndYear(month, year);

        public double GetTotalByYear(int year)=>OrderDAO.Instance.GetTotalByYear(year);

        public void insertOrder(Order order)
        => OrderDAO.Instance.insertOrder(order);

        public List<Order> listOrders()
        => OrderDAO.Instance.listOrders();  

        public void updateTotalOrder(double newTotal, string id)
        => OrderDAO.Instance.updateTotalOrder(newTotal, id);

    }
}
