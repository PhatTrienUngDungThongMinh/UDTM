using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductSupplierDetailDAL
    {
        private readonly DBDataContext db;

        public ProductSupplierDetailDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các ProductSupplierDetails từ cơ sở dữ liệu
        public List<ProductSupplierDetail> GetAllProductSupplierDetails()
        {
            return db.ProductSupplierDetails.ToList();
        }

        // Thêm ProductSupplierDetail vào cơ sở dữ liệu
        public void AddProductSupplierDetail(ProductSupplierDetail detail)
        {
            db.ProductSupplierDetails.InsertOnSubmit(detail);
            db.SubmitChanges();
        }

        // Cập nhật ProductSupplierDetail trong cơ sở dữ liệu
        public void UpdateProductSupplierDetail(ProductSupplierDetail detail)
        {
            var existingDetail = db.ProductSupplierDetails.SingleOrDefault(d => d.id == detail.id);
            if (existingDetail != null)
            {
                existingDetail.ProductID = detail.ProductID;
                existingDetail.SupplierID = detail.SupplierID;
                existingDetail.StartDate = detail.StartDate;
                existingDetail.EndDate = detail.EndDate;
                existingDetail.createdAt = detail.createdAt;
                existingDetail.updatedAt = detail.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("ProductSupplierDetail not found");
            }
        }

        // Xóa ProductSupplierDetail khỏi cơ sở dữ liệu
        public void DeleteProductSupplierDetail(int detailId)
        {
            var detail = db.ProductSupplierDetails.SingleOrDefault(d => d.id == detailId);
            if (detail != null)
            {
                db.ProductSupplierDetails.DeleteOnSubmit(detail);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("ProductSupplierDetail not found");
            }
        }
    }
}
