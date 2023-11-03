using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDAO
{
    public class TypeProductDAO
    {
        private static TypeProductDAO instance = null;
        private TypeProductDAO() { }

        public static TypeProductDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TypeProductDAO();
                }
                return instance;
            }
        }
        public List<TypeProduct> listTypeProduct()
        {
            using var db = new CAGE_SHOPContext();
            return db.TypeProducts.ToList();
        }
        public void insertTypeProduct(TypeProduct typeProduct)
        {
              using var db = new CAGE_SHOPContext();
                db.TypeProducts.Add(typeProduct);
                db.SaveChanges();
        }
        public void updateTypeProduct(TypeProduct typeProduct)
        {
                using var db = new CAGE_SHOPContext();
                db.TypeProducts.Update(typeProduct);
                db.SaveChanges();           
        }
        public void deleteTypeProduct(string id)
        {     
                using var db = new CAGE_SHOPContext();
                var al = db.TypeProducts.SingleOrDefault(m => m.Id.Equals(id));
                db.TypeProducts.Remove(al);
                db.SaveChanges();
        }

    }
}
