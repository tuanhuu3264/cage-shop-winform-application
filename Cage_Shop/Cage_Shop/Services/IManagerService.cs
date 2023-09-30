using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cage_Shop.Services
{
    internal interface IManagerService <T>
    {
         List<T> getPagination(int pageNumber, int pageSize);
         List<T> getAll();
         T getById(string id);
        bool create(T entity);
        bool update(T entity);
        bool delete(T entity);
    }
}
