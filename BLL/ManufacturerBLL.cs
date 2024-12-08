using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ManufacturerBLL
    {
        private readonly ManufacturerDAL manufacturerDAL;

        public ManufacturerBLL(string connectionString)
        {
            manufacturerDAL = new ManufacturerDAL(connectionString);
        }

        // Lấy danh sách tất cả các Manufacturers
        public List<Manufacturer> GetAllManufacturers()
        {
            return manufacturerDAL.GetAllManufacturers();
        }

        // Thêm một Manufacturer mới
        public void AddManufacturer(Manufacturer manufacturer)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(manufacturer.ManufacturerName))
            {
                throw new ArgumentException("Tên Manufacturer không được để trống.");
            }

            // Thêm Manufacturer thông qua DAL
            manufacturerDAL.AddManufacturer(manufacturer);
        }

        // Cập nhật một Manufacturer hiện có
        public void UpdateManufacturer(Manufacturer manufacturer)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(manufacturer.ManufacturerName))
            {
                throw new ArgumentException("Tên Manufacturer không được để trống.");
            }

            // Cập nhật Manufacturer thông qua DAL
            manufacturerDAL.UpdateManufacturer(manufacturer);
        }

        // Xóa một Manufacturer
        public void DeleteManufacturer(int manufacturerId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa Manufacturer thông qua DAL
            manufacturerDAL.DeleteManufacturer(manufacturerId);
        }
    }
}
