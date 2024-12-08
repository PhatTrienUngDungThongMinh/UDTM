using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SupplierDAL
    {
        private readonly DBDataContext db;

        public SupplierDAL()
        {
            db = new DBDataContext();
        }

        public List<Supplier> GetAllSuppliers()
        {
            return db.Suppliers.ToList();
        }

        public void AddSupplier(Supplier supplier)
        {
            db.Suppliers.InsertOnSubmit(supplier);
            db.SubmitChanges();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            var existingSupplier = db.Suppliers.SingleOrDefault(s => s.id == supplier.id);
            if (existingSupplier != null)
            {
                existingSupplier.SupplierName = supplier.SupplierName;
                existingSupplier.Address = supplier.Address;
                existingSupplier.PhoneNumber = supplier.PhoneNumber;
                existingSupplier.Email = supplier.Email;
                existingSupplier.Status = supplier.Status;
                existingSupplier.createdAt = supplier.createdAt;
                existingSupplier.updatedAt = supplier.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Supplier not found");
            }
        }


        public void DeleteSupplier(int supplierId)
        {
            var supplier = db.Suppliers.SingleOrDefault(s => s.id == supplierId);
            if (supplier != null)
            {
                db.Suppliers.DeleteOnSubmit(supplier);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Supplier not found");
            }
        }
    }
}
