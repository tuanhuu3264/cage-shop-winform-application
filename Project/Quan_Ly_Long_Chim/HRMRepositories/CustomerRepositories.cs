using BusinessObject.Models;
using HRMDAO;

namespace HRMRepositories
    {
    public class CustomerRepositories : ICustomerRepositories
    {
        public void deteleCustomer(string id)
        => CustomerDAO.Instance.deteleCustomer(id);
        public void insertCustomer(Customer customer)
        => CustomerDAO.Instance.insertCustomer(customer);   
        public List<Customer> listCustomers()
        => CustomerDAO.Instance.listCustomers();

        public void updateCustomer(Customer customer)
        => CustomerDAO.Instance.updateCustomer(customer);
    }
}