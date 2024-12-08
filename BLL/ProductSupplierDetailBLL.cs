using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductSupplierDetailBLL
    {
        private readonly ProductSupplierDetailDAL productSupplierDetailDAL;

        public ProductSupplierDetailBLL()
        {
            
        }

        // Lấy danh sách tất cả các ProductSupplierDetails
        public List<ProductSupplierDetail> GetAllProductSupplierDetails()
        {
            return productSupplierDetailDAL.GetAllProductSupplierDetails();
        }

        // Thêm một ProductSupplierDetail mới
        public void AddProductSupplierDetail(ProductSupplierDetail detail)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (detail.StartDate > detail.EndDate)
            {
                throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.");
            }

            // Thêm ProductSupplierDetail thông qua DAL
            productSupplierDetailDAL.AddProductSupplierDetail(detail);
        }

        // Cập nhật một ProductSupplierDetail hiện có
        public void UpdateProductSupplierDetail(ProductSupplierDetail detail)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (detail.StartDate > detail.EndDate)
            {
                throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.");
            }

            // Cập nhật ProductSupplierDetail thông qua DAL
            productSupplierDetailDAL.UpdateProductSupplierDetail(detail);
        }

        // Xóa một ProductSupplierDetail
        public void DeleteProductSupplierDetail(int detailId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa ProductSupplierDetail thông qua DAL
            productSupplierDetailDAL.DeleteProductSupplierDetail(detailId);
        }
    }
}
