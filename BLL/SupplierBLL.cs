using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SupplierBLL
    {
        private readonly SupplierDAL supplierDAL = new SupplierDAL();

        public SupplierBLL()
        {
            
        }

        public List<Supplier> GetAllSuppliers()
        {
            return supplierDAL.GetAllSuppliers();
        }
        public void AddSupplier(Supplier supplier)
        {
            if (string.IsNullOrWhiteSpace(supplier.SupplierName))
            {
                throw new ArgumentException("Tên Supplier không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(supplier.Email))
            {
                throw new ArgumentException("Email không được để trống.");
            }

            supplierDAL.AddSupplier(supplier);
        }

        public void UpdateSupplier(Supplier supplier)
        {
            if (string.IsNullOrWhiteSpace(supplier.SupplierName))
            {
                throw new ArgumentException("Tên Supplier không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(supplier.Email))
            {
                throw new ArgumentException("Email không được để trống.");
            }

            supplierDAL.UpdateSupplier(supplier);
        }

        public void DeleteSupplier(int supplierId)
        {

            supplierDAL.DeleteSupplier(supplierId);
        }
    }
}
