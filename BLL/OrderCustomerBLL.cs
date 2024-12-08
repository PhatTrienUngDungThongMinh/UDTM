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
        private readonly OrderCustomerDAL orderCustomerDAL = new OrderCustomerDAL();

        public OrderCustomerBLL()
        {
            
        }

        public List<OrderCustomer> GetAllOrderCustomers()
        {
            return orderCustomerDAL.GetAllOrderCustomers();
        }

        public void AddOrderCustomer(OrderCustomer orderCustomer)
        {
            if (orderCustomer.OrderDate == default(DateTime))
            {
                throw new ArgumentException("Ngày đặt hàng không hợp lệ.");
            }

            if (orderCustomer.TotalAmount < 0)
            {
                throw new ArgumentException("Tổng số tiền không được âm.");
            }

            orderCustomerDAL.AddOrderCustomer(orderCustomer);
        }

        public void UpdateOrderCustomer(OrderCustomer orderCustomer)
        {
            if (orderCustomer.OrderDate == default(DateTime))
            {
                throw new ArgumentException("Ngày đặt hàng không hợp lệ.");
            }

            if (orderCustomer.TotalAmount < 0)
            {
                throw new ArgumentException("Tổng số tiền không được âm.");
            }

            orderCustomerDAL.UpdateOrderCustomer(orderCustomer);
        }

        public void DeleteOrderCustomer(int orderId)
        {

            orderCustomerDAL.DeleteOrderCustomer(orderId);
        }

    }
}
