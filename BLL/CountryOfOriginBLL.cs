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
        private readonly CountryOfOriginDAL countryDAL;

        public CountryOfOriginBLL(string connectionString)
        {
            countryDAL = new CountryOfOriginDAL(connectionString);
        }

        // Lấy danh sách tất cả các CountryOfOrigin
        public List<CountryOfOrigin> GetAllCountries()
        {
            return countryDAL.GetAllCountries();
        }

        // Thêm một CountryOfOrigin mới
        public void AddCountry(CountryOfOrigin country)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(country.CountryName))
            {
                throw new ArgumentException("Tên Quốc Gia không được để trống.");
            }

            // Thêm Country thông qua DAL
            countryDAL.AddCountry(country);
        }

        // Cập nhật một CountryOfOrigin hiện có
        public void UpdateCountry(CountryOfOrigin country)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(country.CountryName))
            {
                throw new ArgumentException("Tên Quốc Gia không được để trống.");
            }

            // Cập nhật Country thông qua DAL
            countryDAL.UpdateCountry(country);
        }

        // Xóa một CountryOfOrigin
        public void DeleteCountry(int countryId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa Country thông qua DAL
            countryDAL.DeleteCountry(countryId);
        }
    }
}
