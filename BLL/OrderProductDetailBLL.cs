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
        private readonly OrderProductDetailDAL orderProductDetailDAL;

        public OrderProductDetailBLL()
        {
            
        }

        // Lấy danh sách tất cả các OrderProductDetails
        public List<OrderProductDetail> GetAllOrderProductDetails()
        {
            return orderProductDetailDAL.GetAllOrderProductDetails();
        }

        // Thêm một OrderProductDetail mới
        public void AddOrderProductDetail(OrderProductDetail orderProductDetail)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (orderProductDetail.Quantity <= 0)
            {
                throw new ArgumentException("Số lượng phải lớn hơn 0.");
            }

            if (Convert.ToInt32(orderProductDetail.UnitPrice) < 0)
            {
                throw new ArgumentException("Giá đơn vị không được âm.");
            }

            // Thêm OrderProductDetail thông qua DAL
            orderProductDetailDAL.AddOrderProductDetail(orderProductDetail);
        }

        // Cập nhật một OrderProductDetail hiện có
        public void UpdateOrderProductDetail(OrderProductDetail orderProductDetail)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (orderProductDetail.Quantity <= 0)
            {
                throw new ArgumentException("Số lượng phải lớn hơn 0.");
            }

            if (Convert.ToInt32(orderProductDetail.UnitPrice) < 0)
            {
                throw new ArgumentException("Giá đơn vị không được âm.");
            }

            // Cập nhật OrderProductDetail thông qua DAL
            orderProductDetailDAL.UpdateOrderProductDetail(orderProductDetail);
        }

        // Xóa một OrderProductDetail
        public void DeleteOrderProductDetail(int detailId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa OrderProductDetail thông qua DAL
            orderProductDetailDAL.DeleteOrderProductDetail(detailId);
        }
    }
}
