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
        private readonly ManufacturerDAL manufacturerDAL = new ManufacturerDAL();

        public ManufacturerBLL()
        {
            
        }

        public List<Manufacturer> GetAllManufacturers()
        {
            return manufacturerDAL.GetAllManufacturers();
        }

        public void AddManufacturer(Manufacturer manufacturer)
        {
            if (string.IsNullOrWhiteSpace(manufacturer.ManufacturerName))
            {
                throw new ArgumentException("Tên Manufacturer không được để trống.");
            }

            manufacturerDAL.AddManufacturer(manufacturer);
        }

        public void UpdateManufacturer(Manufacturer manufacturer)
        {
            if (string.IsNullOrWhiteSpace(manufacturer.ManufacturerName))
            {
                throw new ArgumentException("Tên Manufacturer không được để trống.");
            }

            manufacturerDAL.UpdateManufacturer(manufacturer);
        }

        public void DeleteManufacturer(int manufacturerId)
        {

            manufacturerDAL.DeleteManufacturer(manufacturerId);
        }
    }
}
