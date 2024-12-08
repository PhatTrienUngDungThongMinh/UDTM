using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderCustomerBLL
    {
        private readonly OrderCustomerDAL orderCustomerDAL;

        public OrderCustomerBLL(string connectionString)
        {
            orderCustomerDAL = new OrderCustomerDAL(connectionString);
        }

        // Lấy danh sách tất cả các OrderCustomers
        public List<OrderCustomer> GetAllOrderCustomers()
        {
            return orderCustomerDAL.GetAllOrderCustomers();
        }

        // Thêm một OrderCustomer mới
        public void AddOrderCustomer(OrderCustomer orderCustomer)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (orderCustomer.OrderDate == default(DateTime))
            {
                throw new ArgumentException("Ngày đặt hàng không hợp lệ.");
            }

            if (orderCustomer.TotalAmount < 0)
            {
                throw new ArgumentException("Tổng số tiền không được âm.");
            }

            // Thêm OrderCustomer thông qua DAL
            orderCustomerDAL.AddOrderCustomer(orderCustomer);
        }

        // Cập nhật một OrderCustomer hiện có
        public void UpdateOrderCustomer(OrderCustomer orderCustomer)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (orderCustomer.OrderDate == default(DateTime))
            {
                throw new ArgumentException("Ngày đặt hàng không hợp lệ.");
            }

            if (orderCustomer.TotalAmount < 0)
            {
                throw new ArgumentException("Tổng số tiền không được âm.");
            }

            // Cập nhật OrderCustomer thông qua DAL
            orderCustomerDAL.UpdateOrderCustomer(orderCustomer);
        }

        // Xóa một OrderCustomer
        public void DeleteOrderCustomer(int orderId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa OrderCustomer thông qua DAL
            orderCustomerDAL.DeleteOrderCustomer(orderId);
        }

    }
}
