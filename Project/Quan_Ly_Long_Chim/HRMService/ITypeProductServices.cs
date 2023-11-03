using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMService
{
    public interface ITypeProductServices
    {
        List<TypeProduct> listTypeProduct();
        List<TypeProduct> listIdTypeProduct();
        void insertTypeProduct(TypeProduct typeProduct);
        void updateTypeProduct(TypeProduct typeProduct);
        void deleteTypeProduct(string id);
    }
}
