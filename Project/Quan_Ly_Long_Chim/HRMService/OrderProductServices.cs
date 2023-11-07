using BusinessObject.Models;
using HRMRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HRMDAO.OrderProductDAO;

namespace HRMService
{
    public class OrderProductServices : IOrderProductServices
    {
        private IOrderProductRepositories orderProductRepositories;
        public OrderProductServices()
        {
            orderProductRepositories = new OrderProductRepositories();
        }
        public void deleteOrderProduct(string idOrder)
        {
            orderProductRepositories.deleteOrderProduct(idOrder);
        }

        public void deleteOrderProductByIdOrderAndIdProduct(string idOrder, string idProduct)
        {
            orderProductRepositories.deleteOrderProductByIdOrderAndIdProduct(idOrder, idProduct);
        }

        public IEnumerable<TopProduct> GetTopProduct(int month, int year)
        {
            return orderProductRepositories.GetTopProduct(month, year);
        }

        public IEnumerable<TopTypeProduct> GetTopTypeProduct(int month, int year)
        {
            return orderProductRepositories.GetTopTypeProduct(month, year);
        }

        public double GetTotalProductToSellByMonth(int month, int year)
        {
            return orderProductRepositories.GetTotalProductToSellByMonth(month, year);
        }

        public void insertOrderProduct(OrderProduct orderProduct)
        {
            orderProductRepositories.insertOrderProduct(orderProduct);
        }

        public List<OrderProduct> listOrderProducts()
        {
            return orderProductRepositories.listOrderProducts();
        }

        public List<OrderProduct> listOrderProductsToCancel(string idOrder)
        {
            return orderProductRepositories.listOrderProductsToCancel(idOrder);
        }
    }
}
