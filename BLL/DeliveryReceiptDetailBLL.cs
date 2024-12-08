using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DeliveryReceiptDetailBLL
    {
        private readonly DeliveryReceiptDetailDAL deliveryReceiptDetailDAL;

        public DeliveryReceiptDetailBLL(string connectionString)
        {
            deliveryReceiptDetailDAL = new DeliveryReceiptDetailDAL(connectionString);
        }

        // Lấy danh sách tất cả các DeliveryReceiptDetail
        public List<DeliveryReceiptDetail> GetAllDeliveryReceiptDetails()
        {
            return deliveryReceiptDetailDAL.GetAllDeliveryReceiptDetails();
        }

        // Thêm một DeliveryReceiptDetail mới
        public void AddDeliveryReceiptDetail(DeliveryReceiptDetail detail)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (detail.Quantity <= 0)
            {
                throw new ArgumentException("Số lượng phải lớn hơn 0.");
            }

            if (detail.UnitPrice < 0)
            {
                throw new ArgumentException("Giá đơn vị không được âm.");
            }

            // Thêm DeliveryReceiptDetail thông qua DAL
            deliveryReceiptDetailDAL.AddDeliveryReceiptDetail(detail);
        }

        // Cập nhật một DeliveryReceiptDetail hiện có
        public void UpdateDeliveryReceiptDetail(DeliveryReceiptDetail detail)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (detail.Quantity <= 0)
            {
                throw new ArgumentException("Số lượng phải lớn hơn 0.");
            }

            if (detail.UnitPrice < 0)
            {
                throw new ArgumentException("Giá đơn vị không được âm.");
            }

            // Cập nhật DeliveryReceiptDetail thông qua DAL
            deliveryReceiptDetailDAL.UpdateDeliveryReceiptDetail(detail);
        }

        // Xóa một DeliveryReceiptDetail
        public void DeleteDeliveryReceiptDetail(int detailId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa DeliveryReceiptDetail thông qua DAL
            deliveryReceiptDetailDAL.DeleteDeliveryReceiptDetail(detailId);
        }
    }
}
