using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManufacturerDAL
    {
        private readonly DBDataContext db;

        public ManufacturerDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các Manufacturers từ cơ sở dữ liệu
        public List<Manufacturer> GetAllManufacturers()
        {
            return db.Manufacturers.ToList();
        }

        // Thêm Manufacturer vào cơ sở dữ liệu
        public void AddManufacturer(Manufacturer manufacturer)
        {
            db.Manufacturers.InsertOnSubmit(manufacturer);
            db.SubmitChanges();
        }

        // Cập nhật Manufacturer trong cơ sở dữ liệu
        public void UpdateManufacturer(Manufacturer manufacturer)
        {
            var existingManufacturer = db.Manufacturers.SingleOrDefault(m => m.id == manufacturer.id);
            if (existingManufacturer != null)
            {
                existingManufacturer.ManufacturerName = manufacturer.ManufacturerName;
                existingManufacturer.PathLogo = manufacturer.PathLogo;
                existingManufacturer.createdAt = manufacturer.createdAt;
                existingManufacturer.updatedAt = manufacturer.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Manufacturer not found");
            }
        }

        // Xóa Manufacturer khỏi cơ sở dữ liệu
        public void DeleteManufacturer(int manufacturerId)
        {
            var manufacturer = db.Manufacturers.SingleOrDefault(m => m.id == manufacturerId);
            if (manufacturer != null)
            {
                db.Manufacturers.DeleteOnSubmit(manufacturer);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Manufacturer not found");
            }
        }
    }
}
