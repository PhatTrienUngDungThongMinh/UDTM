using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DeliveryReceiptBLL
    {
        private readonly DeliveryReceiptDAL deliveryReceiptDAL;

        public DeliveryReceiptBLL()
        {
            
        }

        // Lấy danh sách tất cả các DeliveryReceipts
        public List<DeliveryReceipt> GetAllDeliveryReceipts()
        {
            return deliveryReceiptDAL.GetAllDeliveryReceipts();
        }

        // Thêm một DeliveryReceipt mới
        public void AddDeliveryReceipt(DeliveryReceipt receipt)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (receipt.DeliveryDate == default(DateTime))
            {
                throw new ArgumentException("Ngày giao hàng không hợp lệ.");
            }

            // Thêm DeliveryReceipt thông qua DAL
            deliveryReceiptDAL.AddDeliveryReceipt(receipt);
        }

        // Cập nhật một DeliveryReceipt hiện có
        public void UpdateDeliveryReceipt(DeliveryReceipt receipt)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (receipt.DeliveryDate == default(DateTime))
            {
                throw new ArgumentException("Ngày giao hàng không hợp lệ.");
            }

            // Cập nhật DeliveryReceipt thông qua DAL
            deliveryReceiptDAL.UpdateDeliveryReceipt(receipt);
        }

        // Xóa một DeliveryReceipt
        public void DeleteDeliveryReceipt(int receiptId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa DeliveryReceipt thông qua DAL
            deliveryReceiptDAL.DeleteDeliveryReceipt(receiptId);
        }
    }
}
