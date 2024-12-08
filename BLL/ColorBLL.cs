using DTO;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class ColorBLL
    {
        private readonly ColorDAL colorDAL;

        public ColorBLL()
        {
           
        }

        // Lấy danh sách tất cả các Color
        public List<Color> GetAllColors()
        {
            return colorDAL.GetAllColors();
        }

        // Thêm một Color mới
        public void AddColor(Color color)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(color.ColorName))
            {
                throw new ArgumentException("Tên Color không được để trống.");
            }

            // Thêm Color thông qua DAL
            colorDAL.AddColor(color);
        }

        // Cập nhật một Color hiện có
        public void UpdateColor(Color color)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(color.ColorName))
            {
                throw new ArgumentException("Tên Color không được để trống.");
            }

            // Cập nhật Color thông qua DAL
            colorDAL.UpdateColor(color);
        }

        // Xóa một Color
        public void DeleteColor(int colorId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa Color thông qua DAL
            colorDAL.DeleteColor(colorId);
        }

    } 
}
