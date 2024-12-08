using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ScreenBLL
    {
        private readonly ScreenDAL screenDAL;

        public ScreenBLL(string connectionString)
        {
            screenDAL = new ScreenDAL(connectionString);
        }

        // Lấy danh sách tất cả các Screens
        public List<DM_Screen> GetAllScreens()
        {
            return screenDAL.GetAllScreens();
        }

        // Thêm một Screen mới
        public void AddScreen(DM_Screen screen)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(screen.ScreenCode))
            {
                throw new ArgumentException("Mã Screen không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(screen.ScreenName))
            {
                throw new ArgumentException("Tên Screen không được để trống.");
            }

            // Thêm Screen thông qua DAL
            screenDAL.AddScreen(screen);
        }

        // Cập nhật một Screen hiện có
        public void UpdateScreen(DM_Screen screen)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(screen.ScreenName))
            {
                throw new ArgumentException("Tên Screen không được để trống.");
            }

            // Cập nhật Screen thông qua DAL
            screenDAL.UpdateScreen(screen);
        }

        // Xóa một Screen
        public void DeleteScreen(string screenCode)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa Screen thông qua DAL
            screenDAL.DeleteScreen(screenCode);
        }
    }
}
