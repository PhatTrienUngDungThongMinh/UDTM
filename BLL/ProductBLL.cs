using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBLL
    {
        private readonly ProductDAL productDAL = new ProductDAL();

        public ProductBLL()
        {
            
        }

        // Lấy danh sách tất cả các Products
        public List<Product> GetAllProducts()
        {
            return productDAL.GetAllProducts();
        }

        // Thêm một Product mới
        public void AddProduct(Product product)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(product.ProductName))
            {
                throw new ArgumentException("Tên Product không được để trống.");
            }

            if (product.ListedPrice < 0)
            {
                throw new ArgumentException("Giá niêm yết không được âm.");
            }

            if (product.Stock < 0)
            {
                throw new ArgumentException("Số lượng tồn kho không được âm.");
            }

            // Thêm Product thông qua DAL
            productDAL.AddProduct(product);
        }

        // Cập nhật một Product hiện có
        public void UpdateProduct(Product product)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(product.ProductName))
            {
                throw new ArgumentException("Tên Product không được để trống.");
            }

            if (product.ListedPrice < 0)
            {
                throw new ArgumentException("Giá niêm yết không được âm.");
            }

            if (product.Stock < 0)
            {
                throw new ArgumentException("Số lượng tồn kho không được âm.");
            }

            // Cập nhật Product thông qua DAL
            productDAL.UpdateProduct(product);
        }

        // Xóa một Product
        public void DeleteProduct(int productId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa, ví dụ: kiểm tra có đơn hàng liên quan không

            // Xóa Product thông qua DAL
            productDAL.DeleteProduct(productId);
        }
    }
}
