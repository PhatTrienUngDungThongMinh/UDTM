using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShippingAddressDAL
    {
        private readonly DBDataContext db;

        public ShippingAddressDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các ShippingAddresses từ cơ sở dữ liệu
        public List<ShippingAddress> GetAllShippingAddresses()
        {
            return db.ShippingAddresses.ToList();
        }

        // Thêm ShippingAddress vào cơ sở dữ liệu
        public void AddShippingAddress(ShippingAddress address)
        {
            db.ShippingAddresses.InsertOnSubmit(address);
            db.SubmitChanges();
        }

        // Cập nhật ShippingAddress trong cơ sở dữ liệu
        public void UpdateShippingAddress(ShippingAddress address)
        {
            var existingAddress = db.ShippingAddresses.SingleOrDefault(a => a.id == address.id);
            if (existingAddress != null)
            {
                existingAddress.RecipientName = address.RecipientName;
                existingAddress.PhoneNumber = address.PhoneNumber;
                existingAddress.Address = address.Address;
                existingAddress.SpecificAddress = address.SpecificAddress;
                existingAddress.CustomerID = address.CustomerID;
                existingAddress.IsDeleted = address.IsDeleted;
                existingAddress.createdAt = address.createdAt;
                existingAddress.updatedAt = address.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("ShippingAddress not found");
            }
        }

        // Xóa ShippingAddress khỏi cơ sở dữ liệu
        public void DeleteShippingAddress(int addressId)
        {
            var address = db.ShippingAddresses.SingleOrDefault(a => a.id == addressId);
            if (address != null)
            {
                db.ShippingAddresses.DeleteOnSubmit(address);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("ShippingAddress not found");
            }
        }
    }
}
