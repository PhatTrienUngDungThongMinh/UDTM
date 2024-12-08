using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderProductDetailBLL
    {
        private readonly OrderProductDetailDAL orderProductDetailDAL = new OrderProductDetailDAL();

        public OrderProductDetailBLL()
        {
            
        }

        public List<OrderProductDetail> GetAllOrderProductDetails()
        {
            return orderProductDetailDAL.GetAllOrderProductDetails();
        }

        public void AddOrderProductDetail(OrderProductDetail orderProductDetail)
        {
            if (orderProductDetail.Quantity <= 0)
            {
                throw new ArgumentException("Số lượng phải lớn hơn 0.");
            }

            if (Convert.ToInt32(orderProductDetail.UnitPrice) < 0)
            {
                throw new ArgumentException("Giá đơn vị không được âm.");
            }

            orderProductDetailDAL.AddOrderProductDetail(orderProductDetail);
        }

        public void UpdateOrderProductDetail(OrderProductDetail orderProductDetail)
        {
            if (orderProductDetail.Quantity <= 0)
            {
                throw new ArgumentException("Số lượng phải lớn hơn 0.");
            }

            if (Convert.ToInt32(orderProductDetail.UnitPrice) < 0)
            {
                throw new ArgumentException("Giá đơn vị không được âm.");
            }

            orderProductDetailDAL.UpdateOrderProductDetail(orderProductDetail);
        }

        public void DeleteOrderProductDetail(int detailId)
        {
 
            orderProductDetailDAL.DeleteOrderProductDetail(detailId);
        }
    }
}
