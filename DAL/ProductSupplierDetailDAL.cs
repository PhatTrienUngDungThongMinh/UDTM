using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductSupplierDetailDAL
    {
        private readonly DBDataContext db;

        public ProductSupplierDetailDAL()
        {
            db = new DBDataContext();
        }

        public List<ProductSupplierDetail> GetAllProductSupplierDetails()
        {
            return db.ProductSupplierDetails.ToList();
        }

        public void AddProductSupplierDetail(ProductSupplierDetail detail)
        {
            db.ProductSupplierDetails.InsertOnSubmit(detail);
            db.SubmitChanges();
        }

        public void UpdateProductSupplierDetail(ProductSupplierDetail detail)
        {
            var existingDetail = db.ProductSupplierDetails.SingleOrDefault(d => d.id == detail.id);
            if (existingDetail != null)
            {
                existingDetail.ProductID = detail.ProductID;
                existingDetail.SupplierID = detail.SupplierID;
                existingDetail.StartDate = detail.StartDate;
                existingDetail.EndDate = detail.EndDate;
                existingDetail.createdAt = detail.createdAt;
                existingDetail.updatedAt = detail.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("ProductSupplierDetail not found");
            }
        }

        public void DeleteProductSupplierDetail(int detailId)
        {
            var detail = db.ProductSupplierDetails.SingleOrDefault(d => d.id == detailId);
            if (detail != null)
            {
                db.ProductSupplierDetails.DeleteOnSubmit(detail);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("ProductSupplierDetail not found");
            }
        }
    }
}
