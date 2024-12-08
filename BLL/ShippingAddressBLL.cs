using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ShippingAddressBLL
    {
        private readonly ShippingAddressDAL shippingAddressDAL;

        public ShippingAddressBLL(string connectionString)
        {
            shippingAddressDAL = new ShippingAddressDAL(connectionString);
        }

        // Lấy danh sách tất cả các ShippingAddresses
        public List<ShippingAddress> GetAllShippingAddresses()
        {
            return shippingAddressDAL.GetAllShippingAddresses();
        }

        // Thêm một ShippingAddress mới
        public void AddShippingAddress(ShippingAddress address)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(address.RecipientName))
            {
                throw new ArgumentException("Tên người nhận không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(address.PhoneNumber))
            {
                throw new ArgumentException("Số điện thoại không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(address.Address))
            {
                throw new ArgumentException("Địa chỉ không được để trống.");
            }

            // Thêm ShippingAddress thông qua DAL
            shippingAddressDAL.AddShippingAddress(address);
        }

        // Cập nhật một ShippingAddress hiện có
        public void UpdateShippingAddress(ShippingAddress address)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(address.RecipientName))
            {
                throw new ArgumentException("Tên người nhận không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(address.PhoneNumber))
            {
                throw new ArgumentException("Số điện thoại không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(address.Address))
            {
                throw new ArgumentException("Địa chỉ không được để trống.");
            }

            // Cập nhật ShippingAddress thông qua DAL
            shippingAddressDAL.UpdateShippingAddress(address);
        }

        // Xóa một ShippingAddress
        public void DeleteShippingAddress(int addressId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa ShippingAddress thông qua DAL
            shippingAddressDAL.DeleteShippingAddress(addressId);
        }
    }
}
