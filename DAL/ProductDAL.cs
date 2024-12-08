using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        private readonly DBDataContext db;

        public ProductDAL()
        {
            db = new DBDataContext();
        }

        public List<Product> GetAllProducts()
        {
            return db.Products.ToList();
        }

        public void AddProduct(Product product)
        {
            db.Products.InsertOnSubmit(product);
            db.SubmitChanges();
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = db.Products.SingleOrDefault(p => p.id == product.id);
            if (existingProduct != null)
            {
                existingProduct.ProductName = product.ProductName;
                existingProduct.ListedPrice = product.ListedPrice;
                existingProduct.RepresentativeImage = product.RepresentativeImage;
                existingProduct.Stock = product.Stock;
                existingProduct.Description = product.Description;
                existingProduct.PromotionalPrice = product.PromotionalPrice;
                existingProduct.Status = product.Status;
                existingProduct.Sold = product.Sold;
                existingProduct.DeletedAt = product.DeletedAt;
                existingProduct.CreatedBy = product.CreatedBy;
                existingProduct.DeletedBy = product.DeletedBy;
                existingProduct.UpdatedBy = product.UpdatedBy;
                existingProduct.IsDeleted = product.IsDeleted;
                existingProduct.CategoryID = product.CategoryID;
                existingProduct.WarrantyPolicyID = product.WarrantyPolicyID;
                existingProduct.ManufacturerID = product.ManufacturerID;
                existingProduct.CountryID = product.CountryID;
                existingProduct.createdAt = product.createdAt;
                existingProduct.updatedAt = product.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Product not found");
            }
        }

        public void DeleteProduct(int productId)
        {
            var product = db.Products.SingleOrDefault(p => p.id == productId);
            if (product != null)
            {
                db.Products.DeleteOnSubmit(product);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Product not found");
            }
        }
    }
}
