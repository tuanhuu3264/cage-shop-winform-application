using BusinessObject.Models;
using HRMRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMService
{
    public class OrderServices : IOrderServices
    {
        private IOrderRepositories orderRepositories;
        public OrderServices(){
            orderRepositories = new OrderRepositories();
        }
        public bool checkIdOrder(string id)
        {
            return orderRepositories.checkIdOrder(id);
        }

        public void deleteOrder(string id)
        {
            orderRepositories.deleteOrder(id);
        }

        public Order getById(string id)
        {
            return (orderRepositories.getById(id));
        }

        public int GetNumberOrderByDay(int day, int month, int year)
        {
            return orderRepositories.GetNumberOrderByDay(day, month, year);
        }

        public int GetNumberOrderByMonth(int month, int year)
        {
            return orderRepositories.GetNumberOrderByMonth(month, year);
        }

        public int GetNumberOrderByYear(int year)
        {
            return orderRepositories.GetNumberOrderByYear(year);
        }

        public IEnumerable<TypeProduct> GetTopTypeProduct(int month, int year)
        {
            throw new NotImplementedException();
        }

        public double GetTotalByDate(int day, int month, int year)
        {
            return orderRepositories.GetTotalByDate(day, month, year);
        }

        public double GetTotalByMonthAndYear(int month, int year)
        {
            return orderRepositories.GetTotalByMonthAndYear(month, year);
        }

        public double GetTotalByYear(int year)
        {
            return orderRepositories.GetTotalByYear(year);
        }

        public void insertOrder(Order order)
        {
            orderRepositories.insertOrder(order);
        }

        public List<Order> listOrders()
        {
            return orderRepositories.listOrders();
        }

        public void updateTotalOrder(double newTotal, string id)
        {
            orderRepositories.updateTotalOrder(newTotal, id);
        }

    }
}
