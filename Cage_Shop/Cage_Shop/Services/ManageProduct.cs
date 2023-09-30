using Cage_Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cage_Shop.Services
{
    internal class ManageProduct : IManagerService<Product>
    {
        public bool create(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> getAll()
        {
            throw new NotImplementedException();
        }

        public Product getById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Product> getPagination(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public bool update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
