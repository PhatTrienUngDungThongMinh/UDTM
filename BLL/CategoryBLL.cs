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
        private readonly CategoryDAL categoryDAL = new CategoryDAL();

        public CategoryBLL()
        {

        }

        public List<Category> GetAllCategories()
        {
            Console.WriteLine(categoryDAL.GetAllCategories());
            return categoryDAL.GetAllCategories();
        }

        public void AddCategory(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.CategoryName))
            {
                throw new ArgumentException("Tên Category không được để trống.");
            }

            categoryDAL.AddCategory(category);
        }

        public void UpdateCategory(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.CategoryName))
            {
                throw new ArgumentException("Tên Category không được để trống.");
            }

            categoryDAL.UpdateCategory(category);
        }

        public void DeleteCategory(int categoryId)
        {

            categoryDAL.DeleteCategory(categoryId);
        }
    }
}
