using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderCustomerDAL
    {
        private readonly DBDataContext db;

        public OrderCustomerDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các OrderCustomers từ cơ sở dữ liệu
        public List<OrderCustomer> GetAllOrderCustomers()
        {
            return db.OrderCustomers.ToList();
        }

        // Thêm OrderCustomer vào cơ sở dữ liệu
        public void AddOrderCustomer(OrderCustomer orderCustomer)
        {
            db.OrderCustomers.InsertOnSubmit(orderCustomer);
            db.SubmitChanges();
        }

        // Cập nhật OrderCustomer trong cơ sở dữ liệu
        public void UpdateOrderCustomer(OrderCustomer orderCustomer)
        {
            var existingOrder = db.OrderCustomers.SingleOrDefault(o => o.id == orderCustomer.id);
            if (existingOrder != null)
            {
                existingOrder.OrderDate = orderCustomer.OrderDate;
                existingOrder.OrderStatus = orderCustomer.OrderStatus;
                existingOrder.TotalAmount = orderCustomer.TotalAmount;
                existingOrder.PaymentMethodID = orderCustomer.PaymentMethodID;
                existingOrder.EmployeeID = orderCustomer.EmployeeID;
                existingOrder.PromotionID = orderCustomer.PromotionID;
                existingOrder.CustomerID = orderCustomer.CustomerID;
                existingOrder.PaymentStatus = orderCustomer.PaymentStatus;
                existingOrder.PaymentDate = orderCustomer.PaymentDate;
                existingOrder.AddressID = orderCustomer.AddressID;
                existingOrder.createdAt = orderCustomer.createdAt;
                existingOrder.updatedAt = orderCustomer.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("OrderCustomer not found");
            }
        }

        // Xóa OrderCustomer khỏi cơ sở dữ liệu
        public void DeleteOrderCustomer(int orderId)
        {
            var order = db.OrderCustomers.SingleOrDefault(o => o.id == orderId);
            if (order != null)
            {
                db.OrderCustomers.DeleteOnSubmit(order);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("OrderCustomer not found");
            }
        }
    }
}
