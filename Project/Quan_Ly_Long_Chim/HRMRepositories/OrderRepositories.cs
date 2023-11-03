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
        public void insertOrder(Order order)
        => OrderDAO.Instance.insertOrder(order);

        public List<Order> listOrders()
        => OrderDAO.Instance.listOrders();  

        public void updateTotalOrder(double newTotal, string id)
        => OrderDAO.Instance.updateTotalOrder(newTotal, id);

    }
}
