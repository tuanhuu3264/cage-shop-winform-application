using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMRepositories
{
    public interface IProductRepositories
    {
         List<Product> listProducts();

         Product GetProduct(string id);

         bool checkID(string id);

         void insertProduct(Product product);

         void updateProduct(Product product);

         void deleteProduct(string id);
         void updateQuantityProduct(double quantity, string id);
     
    }
}
