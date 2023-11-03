using BusinessObject.Models;
using HRMDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMRepositories
{
    public class OrderProductRepositories : IOrderProductRepositories
    {
        public void deleteOrderProduct(string idOrder)
        => OrderProductDAO.Instance.deleteOrderProduct(idOrder);

        public void deleteOrderProductByIdOrderAndIdProduct(string idOrder, string idProduct)
        => OrderProductDAO.Instance.deleteOrderProductByIdOrderAndIdProduct(idOrder, idProduct);
        public void insertOrderProduct(OrderProduct orderProduct)
        => OrderProductDAO.Instance.insertOrderProduct(orderProduct);

        public List<OrderProduct> listOrderProducts()
        => OrderProductDAO.Instance.listOrderProducts();

        public List<OrderProduct> listOrderProductsToCancel(string idOrder)
        => OrderProductDAO.Instance.listOrderProductsToCancel(idOrder);
    }
}
