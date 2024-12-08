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
        private readonly CustomerDAL customerDAL;

        public CustomerBLL(string connectionString)
        {
            customerDAL = new CustomerDAL(connectionString);
        }

        // Lấy danh sách tất cả các Customer
        public List<Customer> GetAllCustomers()
        {
            return customerDAL.GetAllCustomers();
        }

        // Thêm một Customer mới
        public void AddCustomer(Customer customer)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(customer.CustomerName))
            {
                throw new ArgumentException("Tên Customer không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(customer.Email))
            {
                throw new ArgumentException("Email không được để trống.");
            }

            // Thêm Customer thông qua DAL
            customerDAL.AddCustomer(customer);
        }

        // Cập nhật một Customer hiện có
        public void UpdateCustomer(Customer customer)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(customer.CustomerName))
            {
                throw new ArgumentException("Tên Customer không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(customer.Email))
            {
                throw new ArgumentException("Email không được để trống.");
            }

            // Cập nhật Customer thông qua DAL
            customerDAL.UpdateCustomer(customer);
        }

        // Xóa một Customer
        public void DeleteCustomer(string customerId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa Customer thông qua DAL
            customerDAL.DeleteCustomer(customerId);
        }
    }
}
