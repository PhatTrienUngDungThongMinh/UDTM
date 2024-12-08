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

        public ProductAttributeDAL()
        {
            db = new DBDataContext();
        }

        public List<ProductAttribute> GetAllProductAttributes()
        {
            return db.ProductAttributes.ToList();
        }

        public void AddProductAttribute(ProductAttribute attribute)
        {
            db.ProductAttributes.InsertOnSubmit(attribute);
            db.SubmitChanges();
        }

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
