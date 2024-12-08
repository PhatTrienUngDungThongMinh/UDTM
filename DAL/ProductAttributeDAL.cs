using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductAttributeDAL
    {
        private readonly DBDataContext db;

        public ProductAttributeDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các ProductAttributes từ cơ sở dữ liệu
        public List<ProductAttribute> GetAllProductAttributes()
        {
            return db.ProductAttributes.ToList();
        }

        // Thêm ProductAttribute vào cơ sở dữ liệu
        public void AddProductAttribute(ProductAttribute attribute)
        {
            db.ProductAttributes.InsertOnSubmit(attribute);
            db.SubmitChanges();
        }

        // Cập nhật ProductAttribute trong cơ sở dữ liệu
        public void UpdateProductAttribute(ProductAttribute attribute)
        {
            var existingAttribute = db.ProductAttributes.SingleOrDefault(a => a.id == attribute.id);
            if (existingAttribute != null)
            {
                existingAttribute.AttributeName = attribute.AttributeName;
                existingAttribute.createdAt = attribute.createdAt;
                existingAttribute.updatedAt = attribute.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("ProductAttribute not found");
            }
        }

        // Xóa ProductAttribute khỏi cơ sở dữ liệu
        public void DeleteProductAttribute(int attributeId)
        {
            var attribute = db.ProductAttributes.SingleOrDefault(a => a.id == attributeId);
            if (attribute != null)
            {
                db.ProductAttributes.DeleteOnSubmit(attribute);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("ProductAttribute not found");
            }
        }
    }
}
