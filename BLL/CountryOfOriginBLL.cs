using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CountryOfOriginBLL
    {
        private readonly CountryOfOriginDAL countryDAL = new CountryOfOriginDAL();

        public CountryOfOriginBLL()
        {
            
        }

        public List<CountryOfOrigin> GetAllCountries()
        {
            return countryDAL.GetAllCountries();
        }

        public void AddCountry(CountryOfOrigin country)
        {
            if (string.IsNullOrWhiteSpace(country.CountryName))
            {
                throw new ArgumentException("Tên Quốc Gia không được để trống.");
            }

            countryDAL.AddCountry(country);
        }

        public void UpdateCountry(CountryOfOrigin country)
        {
            if (string.IsNullOrWhiteSpace(country.CountryName))
            {
                throw new ArgumentException("Tên Quốc Gia không được để trống.");
            }

            countryDAL.UpdateCountry(country);
        }

        public void DeleteCountry(int countryId)
        {

            countryDAL.DeleteCountry(countryId);
        }
    }
}
