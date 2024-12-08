using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductAttributeDetailDAL
    {
        private readonly DBDataContext db;

        public ProductAttributeDetailDAL()
        {
            db = new DBDataContext();
        }

        public List<ProductAttributeDetail> GetAllProductAttributeDetails()
        {
            return db.ProductAttributeDetails.ToList();
        }

        public void AddProductAttributeDetail(ProductAttributeDetail detail)
        {
            db.ProductAttributeDetails.InsertOnSubmit(detail);
            db.SubmitChanges();
        }

        public void UpdateProductAttributeDetail(ProductAttributeDetail detail)
        {
            var existingDetail = db.ProductAttributeDetails.SingleOrDefault(d => d.id == detail.id);
            if (existingDetail != null)
            {
                existingDetail.ProductID = detail.ProductID;
                existingDetail.AttributeID = detail.AttributeID;
                existingDetail.AttributeValue = detail.AttributeValue;
                existingDetail.createdAt = detail.createdAt;
                existingDetail.updatedAt = detail.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("ProductAttributeDetail not found");
            }
        }

        public void DeleteProductAttributeDetail(int detailId)
        {
            var detail = db.ProductAttributeDetails.SingleOrDefault(d => d.id == detailId);
            if (detail != null)
            {
                db.ProductAttributeDetails.DeleteOnSubmit(detail);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("ProductAttributeDetail not found");
            }
        }
    }
}
