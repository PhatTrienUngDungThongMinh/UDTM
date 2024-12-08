using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductAttributeBLL
    {
        private readonly ProductAttributeDAL productAttributeDAL = new ProductAttributeDAL();

        public ProductAttributeBLL()
        {
            
        }

        public List<ProductAttribute> GetAllProductAttributes()
        {
            return productAttributeDAL.GetAllProductAttributes();
        }

        public void AddProductAttribute(ProductAttribute attribute)
        {
            if (string.IsNullOrWhiteSpace(attribute.AttributeName))
            {
                throw new ArgumentException("Tên Attribute không được để trống.");
            }

            productAttributeDAL.AddProductAttribute(attribute);
        }

        public void UpdateProductAttribute(ProductAttribute attribute)
        {
            if (string.IsNullOrWhiteSpace(attribute.AttributeName))
            {
                throw new ArgumentException("Tên Attribute không được để trống.");
            }

            productAttributeDAL.UpdateProductAttribute(attribute);
        }

        public void DeleteProductAttribute(int attributeId)
        {

            productAttributeDAL.DeleteProductAttribute(attributeId);
        }
    }
}
