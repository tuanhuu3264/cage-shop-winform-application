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
