using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class CategoryBLL
    {
        private readonly CategoryBLL categoryDAL;

        public CategoryBLL()
        {
        }

        // Lấy danh sách tất cả các Category
        public List<Category> GetAllCategories()
        {
            return categoryDAL.GetAllCategories();
        }

        // Thêm một Category mới
        public void AddCategory(Category category)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(category.CategoryName))
            {
                throw new ArgumentException("Tên Category không được để trống.");
            }

            // Thêm Category thông qua DAL
            categoryDAL.AddCategory(category);
        }

        // Cập nhật một Category hiện có
        public void UpdateCategory(Category category)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(category.CategoryName))
            {
                throw new ArgumentException("Tên Category không được để trống.");
            }

            // Cập nhật Category thông qua DAL
            categoryDAL.UpdateCategory(category);
        }

        // Xóa một Category
        public void DeleteCategory(int categoryId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa, ví dụ: kiểm tra xem có sản phẩm liên quan không

            // Xóa Category thông qua DAL
            categoryDAL.DeleteCategory(categoryId);
        }
    }
}
