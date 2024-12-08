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
        private readonly ProductAttributeDAL productAttributeDAL;

        public ProductAttributeBLL()
        {
            
        }

        // Lấy danh sách tất cả các ProductAttributes
        public List<ProductAttribute> GetAllProductAttributes()
        {
            return productAttributeDAL.GetAllProductAttributes();
        }

        // Thêm một ProductAttribute mới
        public void AddProductAttribute(ProductAttribute attribute)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(attribute.AttributeName))
            {
                throw new ArgumentException("Tên Attribute không được để trống.");
            }

            // Thêm ProductAttribute thông qua DAL
            productAttributeDAL.AddProductAttribute(attribute);
        }

        // Cập nhật một ProductAttribute hiện có
        public void UpdateProductAttribute(ProductAttribute attribute)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(attribute.AttributeName))
            {
                throw new ArgumentException("Tên Attribute không được để trống.");
            }

            // Cập nhật ProductAttribute thông qua DAL
            productAttributeDAL.UpdateProductAttribute(attribute);
        }

        // Xóa một ProductAttribute
        public void DeleteProductAttribute(int attributeId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa ProductAttribute thông qua DAL
            productAttributeDAL.DeleteProductAttribute(attributeId);
        }
    }
}
