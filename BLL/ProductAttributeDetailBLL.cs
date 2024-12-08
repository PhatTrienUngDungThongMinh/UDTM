using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductAttributeDetailBLL
    {
        private readonly ProductAttributeDetailDAL productAttributeDetailDAL;

        public ProductAttributeDetailBLL()
        {
            
        }

        // Lấy danh sách tất cả các ProductAttributeDetails
        public List<ProductAttributeDetail> GetAllProductAttributeDetails()
        {
            return productAttributeDetailDAL.GetAllProductAttributeDetails();
        }

        // Thêm một ProductAttributeDetail mới
        public void AddProductAttributeDetail(ProductAttributeDetail detail)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(detail.AttributeValue))
            {
                throw new ArgumentException("Giá trị Attribute không được để trống.");
            }

            // Thêm ProductAttributeDetail thông qua DAL
            productAttributeDetailDAL.AddProductAttributeDetail(detail);
        }

        // Cập nhật một ProductAttributeDetail hiện có
        public void UpdateProductAttributeDetail(ProductAttributeDetail detail)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(detail.AttributeValue))
            {
                throw new ArgumentException("Giá trị Attribute không được để trống.");
            }

            // Cập nhật ProductAttributeDetail thông qua DAL
            productAttributeDetailDAL.UpdateProductAttributeDetail(detail);
        }

        // Xóa một ProductAttributeDetail
        public void DeleteProductAttributeDetail(int detailId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa ProductAttributeDetail thông qua DAL
            productAttributeDetailDAL.DeleteProductAttributeDetail(detailId);
        }
    }
}
