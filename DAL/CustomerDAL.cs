using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        private readonly DBDataContext db;

        public CustomerDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các Customer từ cơ sở dữ liệu
        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        // Thêm Customer vào cơ sở dữ liệu
        public void AddCustomer(Customer customer)
        {
            db.Customers.InsertOnSubmit(customer);
            db.SubmitChanges();
        }

        // Cập nhật Customer trong cơ sở dữ liệu
        public void UpdateCustomer(Customer customer)
        {
            var existingCustomer = db.Customers.SingleOrDefault(c => c.id == customer.id);
            if (existingCustomer != null)
            {
                existingCustomer.CustomerName = customer.CustomerName;
                existingCustomer.Gender = customer.Gender;
                existingCustomer.JoinDate = customer.JoinDate;
                existingCustomer.Email = customer.Email;
                existingCustomer.PhoneNumber = customer.PhoneNumber;
                existingCustomer.BirthDate = customer.BirthDate;
                existingCustomer.Password = customer.Password;
                existingCustomer.IsActive = customer.IsActive;
                existingCustomer.createdAt = customer.createdAt;
                existingCustomer.updatedAt = customer.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Customer not found");
            }
        }

        // Xóa Customer khỏi cơ sở dữ liệu
        public void DeleteCustomer(string customerId)
        {
            var customer = db.Customers.SingleOrDefault(c => c.id == customerId);
            if (customer != null)
            {
                db.Customers.DeleteOnSubmit(customer);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Customer not found");
            }
        }
    }
}
