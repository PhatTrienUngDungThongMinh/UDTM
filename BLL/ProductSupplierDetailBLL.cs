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
        private readonly ProductSupplierDetailDAL productSupplierDetailDAL = new ProductSupplierDetailDAL();

        public ProductSupplierDetailBLL()
        {
            
        }

        public List<ProductSupplierDetail> GetAllProductSupplierDetails()
        {
            return productSupplierDetailDAL.GetAllProductSupplierDetails();
        }

        public void AddProductSupplierDetail(ProductSupplierDetail detail)
        {
            if (detail.StartDate > detail.EndDate)
            {
                throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.");
            }

            productSupplierDetailDAL.AddProductSupplierDetail(detail);
        }

        public void UpdateProductSupplierDetail(ProductSupplierDetail detail)
        {
            if (detail.StartDate > detail.EndDate)
            {
                throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.");
            }

            productSupplierDetailDAL.UpdateProductSupplierDetail(detail);
        }

        public void DeleteProductSupplierDetail(int detailId)
        {
            productSupplierDetailDAL.DeleteProductSupplierDetail(detailId);
        }
    }
}
