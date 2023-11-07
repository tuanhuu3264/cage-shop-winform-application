using BusinessObject.Models;
using HRMDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMRepositories
{
    public class ProductRepositories : IProductRepositories
    {
        public bool checkID(string id)
        => ProductDAO.Instance.checkID(id);

        public void deleteProduct(string id)
        => ProductDAO.Instance.deleteProduct(id);
        public Product GetProduct(string id)
        => ProductDAO.Instance.GetProduct(id);

        public double GetTotalStockProduct()
        => ProductDAO.Instance.GetTotalStockProduct();

        public void insertProduct(Product product)
        => ProductDAO.Instance.insertProduct(product);

        public List<Product> listProducts()
        => ProductDAO.Instance.listProducts();

        public void updateProduct(Product product)
        => ProductDAO.Instance.updateProduct(product);

        public void updateQuantityProduct(double quantity, string id)
        => ProductDAO.Instance.updateQuantityProduct(quantity, id);
    }
}
