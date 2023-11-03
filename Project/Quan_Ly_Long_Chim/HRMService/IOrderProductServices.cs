using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMService
{
    public interface IOrderProductServices
    {
        List<OrderProduct> listOrderProducts();
        void insertOrderProduct(OrderProduct orderProduct);

        List<OrderProduct> listOrderProductsToCancel(string idOrder);

        void deleteOrderProduct(string idOrder);

        void deleteOrderProductByIdOrderAndIdProduct(string idOrder, string idProduct);
    }
}
