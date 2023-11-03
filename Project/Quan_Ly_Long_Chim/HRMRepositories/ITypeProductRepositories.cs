using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMRepositories
{
    public interface ITypeProductRepositories
    {
         List<TypeProduct> listTypeProduct();
         void insertTypeProduct(TypeProduct typeProduct);

         void updateTypeProduct(TypeProduct typeProduct);

         void deleteTypeProduct(string id);
     
        
    }
}
