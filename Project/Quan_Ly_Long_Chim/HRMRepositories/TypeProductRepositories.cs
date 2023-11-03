using BusinessObject.Models;
using HRMDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMRepositories
{
    public class TypeProductRepositories : ITypeProductRepositories
    {
        public void deleteTypeProduct(string id)
        => TypeProductDAO.Instance.deleteTypeProduct(id);
        public void insertTypeProduct(TypeProduct typeProduct)
        => TypeProductDAO.Instance.insertTypeProduct(typeProduct);
        public List<TypeProduct> listTypeProduct()
        => TypeProductDAO.Instance.listTypeProduct();

        public void updateTypeProduct(TypeProduct typeProduct)
        => TypeProductDAO.Instance.updateTypeProduct(typeProduct);
    }
}
