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
        private readonly ShippingAddressDAL shippingAddressDAL = new ShippingAddressDAL();

        public ShippingAddressBLL()
        {
            
        }

        public List<ShippingAddress> GetAllShippingAddresses()
        {
            return shippingAddressDAL.GetAllShippingAddresses();
        }

        public void AddShippingAddress(ShippingAddress address)
        {
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

            shippingAddressDAL.AddShippingAddress(address);
        }

        public void UpdateShippingAddress(ShippingAddress address)
        {
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

            shippingAddressDAL.UpdateShippingAddress(address);
        }

        public void DeleteShippingAddress(int addressId)
        {

            shippingAddressDAL.DeleteShippingAddress(addressId);
        }
    }
}
