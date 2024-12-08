using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductAttributeDetailDAL
    {
        private readonly DBDataContext db;

        public ProductAttributeDetailDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các ProductAttributeDetails từ cơ sở dữ liệu
        public List<ProductAttributeDetail> GetAllProductAttributeDetails()
        {
            return db.ProductAttributeDetails.ToList();
        }

        // Thêm ProductAttributeDetail vào cơ sở dữ liệu
        public void AddProductAttributeDetail(ProductAttributeDetail detail)
        {
            db.ProductAttributeDetails.InsertOnSubmit(detail);
            db.SubmitChanges();
        }

        // Cập nhật ProductAttributeDetail trong cơ sở dữ liệu
        public void UpdateProductAttributeDetail(ProductAttributeDetail detail)
        {
            var existingDetail = db.ProductAttributeDetails.SingleOrDefault(d => d.id == detail.id);
            if (existingDetail != null)
            {
                existingDetail.ProductID = detail.ProductID;
                existingDetail.AttributeID = detail.AttributeID;
                existingDetail.AttributeValue = detail.AttributeValue;
                existingDetail.createdAt = detail.createdAt;
                existingDetail.updatedAt = detail.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("ProductAttributeDetail not found");
            }
        }

        // Xóa ProductAttributeDetail khỏi cơ sở dữ liệu
        public void DeleteProductAttributeDetail(int detailId)
        {
            var detail = db.ProductAttributeDetails.SingleOrDefault(d => d.id == detailId);
            if (detail != null)
            {
                db.ProductAttributeDetails.DeleteOnSubmit(detail);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("ProductAttributeDetail not found");
            }
        }
    }
}
