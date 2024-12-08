using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerBLL
    {
        private readonly CustomerDAL customerDAL = new CustomerDAL();

        public CustomerBLL()
        {
            
        }

        public List<Customer> GetAllCustomers()
        {
            return customerDAL.GetAllCustomers();
        }

        public void AddCustomer(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.CustomerName))
            {
                throw new ArgumentException("Tên Customer không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(customer.Email))
            {
                throw new ArgumentException("Email không được để trống.");
            }

            customerDAL.AddCustomer(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.CustomerName))
            {
                throw new ArgumentException("Tên Customer không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(customer.Email))
            {
                throw new ArgumentException("Email không được để trống.");
            }

            customerDAL.UpdateCustomer(customer);
        }

        public void DeleteCustomer(string customerId)
        {

            customerDAL.DeleteCustomer(customerId);
        }
    }
}
