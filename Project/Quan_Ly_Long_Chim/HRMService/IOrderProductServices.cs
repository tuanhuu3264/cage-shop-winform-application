using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HRMDAO.OrderProductDAO;

namespace HRMService
{
    public interface IOrderProductServices
    {
        List<OrderProduct> listOrderProducts();
        void insertOrderProduct(OrderProduct orderProduct);

        List<OrderProduct> listOrderProductsToCancel(string idOrder);

        void deleteOrderProduct(string idOrder);

        void deleteOrderProductByIdOrderAndIdProduct(string idOrder, string idProduct);
        IEnumerable<TopTypeProduct> GetTopTypeProduct(int month, int year);
        IEnumerable<TopProduct> GetTopProduct(int month, int year);
        double GetTotalProductToSellByMonth(int month, int year);
    }
}
