using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ScreenDAL
    {
        private readonly DBDataContext db;

        public ScreenDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các Screen từ cơ sở dữ liệu
        public List<DM_Screen> GetAllScreens()
        {
            return db.DM_Screens.ToList();
        }

        // Thêm Screen vào cơ sở dữ liệu
        public void AddScreen(DM_Screen screen)
        {
            db.DM_Screens.InsertOnSubmit(screen);
            db.SubmitChanges();
        }

        // Cập nhật Screen trong cơ sở dữ liệu
        public void UpdateScreen(DM_Screen screen)
        {
            var existingScreen = db.DM_Screens.SingleOrDefault(s => s.ScreenCode == screen.ScreenCode);
            if (existingScreen != null)
            {
                existingScreen.ScreenName = screen.ScreenName;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Screen not found");
            }
        }

        // Xóa Screen khỏi cơ sở dữ liệu
        public void DeleteScreen(string screenCode)
        {
            var screen = db.DM_Screens.SingleOrDefault(s => s.ScreenCode == screenCode);
            if (screen != null)
            {
                db.DM_Screens.DeleteOnSubmit(screen);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Screen not found");
            }
        }
    }
}
