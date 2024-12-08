using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class CategoryDAL
    {
        private readonly DBDataContext db = new DBDataContext();

        public CategoryDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các Category từ cơ sở dữ liệu
        public List<Category> GetAllCategories()
        {
            return db.Categories.ToList();
        }

        // Thêm Category vào cơ sở dữ liệu
        public void AddCategory(Category category)
        {
            db.Categories.InsertOnSubmit(category);
            db.SubmitChanges();
        }

        // Cập nhật Category trong cơ sở dữ liệu
        public void UpdateCategory(Category category)
        {
            var existingCategory = db.Categories.SingleOrDefault(c => c.id == category.id);
            if (existingCategory != null)
            {
                existingCategory.CategoryName = category.CategoryName;
                existingCategory.pathImg = category.pathImg;
                existingCategory.createdAt = category.createdAt;
                existingCategory.updatedAt = category.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Category not found");
            }
        }

        // Xóa Category khỏi cơ sở dữ liệu
        public void DeleteCategory(int categoryId)
        {
            var category = db.Categories.SingleOrDefault(c => c.id == categoryId);
            if (category != null)
            {
                db.Categories.DeleteOnSubmit(category);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Category not found");
            }
        }
    }
}
