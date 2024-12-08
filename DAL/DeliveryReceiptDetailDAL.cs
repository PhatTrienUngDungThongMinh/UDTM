using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeliveryReceiptDetailDAL
    {
        private readonly DBDataContext db;

        public DeliveryReceiptDetailDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các DeliveryReceiptDetail từ cơ sở dữ liệu
        public List<DeliveryReceiptDetail> GetAllDeliveryReceiptDetails()
        {
            return db.DeliveryReceiptDetails.ToList();
        }

        // Thêm DeliveryReceiptDetail vào cơ sở dữ liệu
        public void AddDeliveryReceiptDetail(DeliveryReceiptDetail detail)
        {
            db.DeliveryReceiptDetails.InsertOnSubmit(detail);
            db.SubmitChanges();
        }

        // Cập nhật DeliveryReceiptDetail trong cơ sở dữ liệu
        public void UpdateDeliveryReceiptDetail(DeliveryReceiptDetail detail)
        {
            var existingDetail = db.DeliveryReceiptDetails.SingleOrDefault(d => d.id == detail.id);
            if (existingDetail != null)
            {
                existingDetail.ProductID = detail.ProductID;
                existingDetail.ReceiptID = detail.ReceiptID;
                existingDetail.Quantity = detail.Quantity;
                existingDetail.UnitPrice = detail.UnitPrice;
                existingDetail.TotalPrice = detail.TotalPrice;
                existingDetail.Unit = detail.Unit;
                existingDetail.createdAt = detail.createdAt;
                existingDetail.updatedAt = detail.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("DeliveryReceiptDetail not found");
            }
        }

        // Xóa DeliveryReceiptDetail khỏi cơ sở dữ liệu
        public void DeleteDeliveryReceiptDetail(int detailId)
        {
            var detail = db.DeliveryReceiptDetails.SingleOrDefault(d => d.id == detailId);
            if (detail != null)
            {
                db.DeliveryReceiptDetails.DeleteOnSubmit(detail);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("DeliveryReceiptDetail not found");
            }
        }
    }
}
