using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDAO
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private ProductDAO() { }

        public static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductDAO();
                }
                return instance;
            }
        }
        public IEnumerable<Product> listProducts()
        {
            using var db = new CAGE_SHOPContext();
            return db.Products.Include(c => c.IdTypeProductNavigation).ToList();
        }
        public Product GetProduct(string id) {
            var temp = listProducts().SingleOrDefault(m => m.Id == id);
                return temp;  
        }
        public bool checkID(string id)
        {
            var temp = listProducts().FirstOrDefault(m => m.Id == id);
            if(temp != null)
            {
                return true;
            }
            return false;
        }
        public void insertProduct(Product product)
        {

            using var db = new CAGE_SHOPContext();
            var teamp = listProducts().FirstOrDefault(m => m.Id == product.Id);
            if (teamp == null)
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
            else
            {
                throw new Exception("Đã tồn tại sản phẩm!");
            }
        }
        public void updateProduct(Product product)
        {
            using var db = new CAGE_SHOPContext();
            db.Products.Update(product);
            db.SaveChanges();
        }
        public void deleteProduct(string id)
        {
            var temp = GetProduct(id);
            if(temp != null)
            {
                using var db = new CAGE_SHOPContext();
                db.Products.Remove(temp);
                db.SaveChanges();
            }
        }
        public void updateQuantityProduct(double quantity, string id)
        {
                using var db = new CAGE_SHOPContext();
                var product = db.Products.FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    product.Quantity = ((int)quantity);
                    db.SaveChanges();
                }
         }
        public double GetTotalStockProduct()
        {
            var number = listProducts().Sum(m=>m.Quantity);
            return (double)(number !=null? number : 0);
        }
    }
}
