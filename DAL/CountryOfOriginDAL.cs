using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CountryOfOriginDAL
    {
        private readonly DBDataContext db;

        public CountryOfOriginDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các CountryOfOrigin từ cơ sở dữ liệu
        public List<CountryOfOrigin> GetAllCountries()
        {
            return db.CountryOfOrigins.ToList();
        }

        // Thêm CountryOfOrigin vào cơ sở dữ liệu
        public void AddCountry(CountryOfOrigin country)
        {
            db.CountryOfOrigins.InsertOnSubmit(country);
            db.SubmitChanges();
        }

        // Cập nhật CountryOfOrigin trong cơ sở dữ liệu
        public void UpdateCountry(CountryOfOrigin country)
        {
            var existingCountry = db.CountryOfOrigins.SingleOrDefault(c => c.id == country.id);
            if (existingCountry != null)
            {
                existingCountry.CountryName = country.CountryName;
                existingCountry.createdAt = country.createdAt;
                existingCountry.updatedAt = country.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("CountryOfOrigin not found");
            }
        }

        // Xóa CountryOfOrigin khỏi cơ sở dữ liệu
        public void DeleteCountry(int countryId)
        {
            var country = db.CountryOfOrigins.SingleOrDefault(c => c.id == countryId);
            if (country != null)
            {
                db.CountryOfOrigins.DeleteOnSubmit(country);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("CountryOfOrigin not found");
            }
        }
    }
}
