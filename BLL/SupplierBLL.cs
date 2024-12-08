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
        private readonly SupplierDAL supplierDAL;

        public SupplierBLL(string connectionString)
        {
            supplierDAL = new SupplierDAL(connectionString);
        }

        // Lấy danh sách tất cả các Suppliers
        public List<Supplier> GetAllSuppliers()
        {
            return supplierDAL.GetAllSuppliers();
        }

        // Thêm một Supplier mới
        public void AddSupplier(Supplier supplier)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(supplier.SupplierName))
            {
                throw new ArgumentException("Tên Supplier không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(supplier.Email))
            {
                throw new ArgumentException("Email không được để trống.");
            }

            // Thêm Supplier thông qua DAL
            supplierDAL.AddSupplier(supplier);
        }

        // Cập nhật một Supplier hiện có
        public void UpdateSupplier(Supplier supplier)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(supplier.SupplierName))
            {
                throw new ArgumentException("Tên Supplier không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(supplier.Email))
            {
                throw new ArgumentException("Email không được để trống.");
            }

            // Cập nhật Supplier thông qua DAL
            supplierDAL.UpdateSupplier(supplier);
        }

        // Xóa một Supplier
        public void DeleteSupplier(int supplierId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa Supplier thông qua DAL
            supplierDAL.DeleteSupplier(supplierId);
        }
    }
}
