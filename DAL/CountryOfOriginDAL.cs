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

        public CountryOfOriginDAL()
        {
            db = new DBDataContext();
        }

        public List<CountryOfOrigin> GetAllCountries()
        {
            return db.CountryOfOrigins.ToList();
        }

        public void AddCountry(CountryOfOrigin country)
        {
            db.CountryOfOrigins.InsertOnSubmit(country);
            db.SubmitChanges();
        }

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
