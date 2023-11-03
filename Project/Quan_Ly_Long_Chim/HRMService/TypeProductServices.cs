using BusinessObject.Models;
using HRMRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HRMService
{
    public class TypeProductServices : ITypeProductServices
    {
        private ITypeProductRepositories typeProductRepositories;
        public TypeProductServices()
        {
            typeProductRepositories = new TypeProductRepositories();
        }
        public void deleteTypeProduct(string id)
        {
            typeProductRepositories.deleteTypeProduct(id);
        }
        public void insertTypeProduct(TypeProduct typeProduct)
        {
            typeProductRepositories.insertTypeProduct(typeProduct);
        }

        public List<TypeProduct> listIdTypeProduct()
        {
            return typeProductRepositories.listTypeProduct();
        }

        public List<TypeProduct> listTypeProduct()
        {
            return listIdTypeProduct();
        }

        public void updateTypeProduct(TypeProduct typeProduct)
        {
            typeProductRepositories.updateTypeProduct(typeProduct);
        }
    }
}
