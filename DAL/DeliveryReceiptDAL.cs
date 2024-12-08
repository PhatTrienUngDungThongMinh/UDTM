using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeliveryReceiptDAL
    {
        private readonly DBDataContext db;

        public DeliveryReceiptDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các DeliveryReceipts từ cơ sở dữ liệu
        public List<DeliveryReceipt> GetAllDeliveryReceipts()
        {
            return db.DeliveryReceipts.ToList();
        }

        // Thêm DeliveryReceipt vào cơ sở dữ liệu
        public void AddDeliveryReceipt(DeliveryReceipt receipt)
        {
            db.DeliveryReceipts.InsertOnSubmit(receipt);
            db.SubmitChanges();
        }

        // Cập nhật DeliveryReceipt trong cơ sở dữ liệu
        public void UpdateDeliveryReceipt(DeliveryReceipt receipt)
        {
            var existingReceipt = db.DeliveryReceipts.SingleOrDefault(r => r.id == receipt.id);
            if (existingReceipt != null)
            {
                existingReceipt.DeliveryDate = receipt.DeliveryDate;
                existingReceipt.Notes = receipt.Notes;
                existingReceipt.SupplierID = receipt.SupplierID;
                existingReceipt.EmployeeID = receipt.EmployeeID;
                existingReceipt.Status = receipt.Status;
                existingReceipt.createdAt = receipt.createdAt;
                existingReceipt.updatedAt = receipt.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("DeliveryReceipt not found");
            }
        }

        // Xóa DeliveryReceipt khỏi cơ sở dữ liệu
        public void DeleteDeliveryReceipt(int receiptId)
        {
            var receipt = db.DeliveryReceipts.SingleOrDefault(r => r.id == receiptId);
            if (receipt != null)
            {
                db.DeliveryReceipts.DeleteOnSubmit(receipt);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("DeliveryReceipt not found");
            }
        }
    }
}
