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

         bool checkIdOrder(string id);
         void insertOrder(Order order);
         void updateTotalOrder(double newTotal, string id);

         void deleteOrder(string id);
    }
}
