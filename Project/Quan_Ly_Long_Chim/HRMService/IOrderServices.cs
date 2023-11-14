using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMService
{
    public interface IOrderServices
    {
         List<Order> listOrders();
        Order getById(string id);

         bool checkIdOrder(string id);
         void insertOrder(Order order);
         void updateTotalOrder(double newTotal, string id);
         void deleteOrder(string id);
        double GetTotalByMonthAndYear(int month, int year);
        IEnumerable<TypeProduct> GetTopTypeProduct(int month, int year);
        double GetTotalByDate(int day, int month, int year);
        int GetNumberOrderByMonth(int month, int year);
        double GetTotalByYear(int year);
        int GetNumberOrderByYear(int year);
        int GetNumberOrderByDay(int day, int month, int year);
    }
}
