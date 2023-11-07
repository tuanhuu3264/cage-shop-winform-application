using BusinessObject.Models;
using HRMDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMRepositories
{
    public interface ICustomerRepositories
    {
         List<Customer> listCustomers();
         void insertCustomer(Customer customer);

         void updateCustomer(Customer customer);

         void deteleCustomer(string id);
        int NumberNewCustomerByMonth(int month, int year);

    }
}
