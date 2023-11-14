using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMRepositories
{
    public interface IOrderRepositories
    {
         List<Order> listOrders();

         bool checkIdOrder(string id);
         void insertOrder(Order order);
         void updateTotalOrder(double newTotal, string id);
          
         Order getById(string id);
         void deleteOrder(string id);
        int GetNumberOrderByDay(int day, int month, int year);
        int GetNumberOrderByMonth(int month, int year);
        int GetNumberOrderByYear(int year);
        double GetTotalByDate(int day, int month, int year);
        double GetTotalByMonthAndYear(int month, int year);
        double GetTotalByYear(int year);
        IEnumerable<Object> GetTopTypeProduct(int month, int year);
    }
}
