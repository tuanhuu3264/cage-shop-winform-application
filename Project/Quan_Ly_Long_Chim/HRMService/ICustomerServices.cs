using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMService
{
    public interface ICustomerServices
    {
         List<Customer> listCustomers();
         void insertCustomer(Customer customer);
         void updateCustomer(Customer customer);
         void deteleCustomer(string id);
    }
}
