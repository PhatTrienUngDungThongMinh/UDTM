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

        public List<Product> GetAllProducts()
        {
            return productDAL.GetAllProducts();
        }

        public void AddProduct(Product product)
        {
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

            productDAL.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
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

            productDAL.UpdateProduct(product);
        }

        public void DeleteProduct(int productId)
        {
            productDAL.DeleteProduct(productId);
        }
    }
}
