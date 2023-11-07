using BusinessObject.Models;
using HRMDAO;
using HRMRepositories;

namespace HRMService
{
    public class CustomerServices : ICustomerServices
    {
        private ICustomerRepositories customerRepositories;
        public CustomerServices()
        {
            customerRepositories = new CustomerRepositories();
        }
        public void deteleCustomer(string id)
        {
            customerRepositories.deteleCustomer(id);
        }

        public void insertCustomer(Customer customer)
        {
            customerRepositories.insertCustomer(customer);
        }

        public List<Customer> listCustomers()
        {
            return customerRepositories.listCustomers();
        }

        public int NumberNewCustomerByMonth(int month, int year)
        {
            return customerRepositories.NumberNewCustomerByMonth(month, year);
        }

        public void updateCustomer(Customer customer)
        {
            customerRepositories.updateCustomer(customer);
        }
    }
}
