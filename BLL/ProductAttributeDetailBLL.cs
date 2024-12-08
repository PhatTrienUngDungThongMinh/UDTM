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
        private readonly ProductAttributeDetailDAL productAttributeDetailDAL = new ProductAttributeDetailDAL();

        public ProductAttributeDetailBLL()
        {
            
        }

        public List<ProductAttributeDetail> GetAllProductAttributeDetails()
        {
            return productAttributeDetailDAL.GetAllProductAttributeDetails();
        }

        public void AddProductAttributeDetail(ProductAttributeDetail detail)
        {
            if (string.IsNullOrWhiteSpace(detail.AttributeValue))
            {
                throw new ArgumentException("Giá trị Attribute không được để trống.");
            }

            productAttributeDetailDAL.AddProductAttributeDetail(detail);
        }

        public void UpdateProductAttributeDetail(ProductAttributeDetail detail)
        {
            if (string.IsNullOrWhiteSpace(detail.AttributeValue))
            {
                throw new ArgumentException("Giá trị Attribute không được để trống.");
            }

            productAttributeDetailDAL.UpdateProductAttributeDetail(detail);
        }

        public void DeleteProductAttributeDetail(int detailId)
        {

            productAttributeDetailDAL.DeleteProductAttributeDetail(detailId);
        }
    }
}
