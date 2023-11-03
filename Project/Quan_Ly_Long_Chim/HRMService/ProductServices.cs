using BusinessObject.Models;
using HRMRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMService
{
    public class ProductServices : IProductServices
    {
        private IProductRepositories productRepositories;
        public ProductServices()
        {
            productRepositories = new ProductRepositories();
        }
        public bool checkID(string id)
        {
            return productRepositories.checkID(id);
        }

        public void deleteProduct(string id)
        {
            productRepositories.deleteProduct(id);
        }
        public Product GetProduct(string id)
        {
            return productRepositories.GetProduct(id);
        }
        public void insertProduct(Product product)
        {
            productRepositories.insertProduct(product);
        }

        public List<Product> listProducts()
        {
            return productRepositories.listProducts();
        }

        public void updateProduct(Product product)
        {
            productRepositories.updateProduct(product);
        }

        public void updateQuantityProduct(double quantity, string id)
        {
            productRepositories.updateQuantityProduct(quantity, id);
        }
    }
}
