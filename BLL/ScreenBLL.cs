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
        private readonly ScreenDAL screenDAL = new ScreenDAL();

        public ScreenBLL()
        {
            
        }

        public List<DM_Screen> GetAllScreens()
        {
            return screenDAL.GetAllScreens();
        }

        public void AddScreen(DM_Screen screen)
        {
            if (string.IsNullOrWhiteSpace(screen.ScreenCode))
            {
                throw new ArgumentException("Mã Screen không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(screen.ScreenName))
            {
                throw new ArgumentException("Tên Screen không được để trống.");
            }

            screenDAL.AddScreen(screen);
        }

        public void UpdateScreen(DM_Screen screen)
        {
            if (string.IsNullOrWhiteSpace(screen.ScreenName))
            {
                throw new ArgumentException("Tên Screen không được để trống.");
            }

            screenDAL.UpdateScreen(screen);
        }

        public void DeleteScreen(string screenCode)
        {

            screenDAL.DeleteScreen(screenCode);
        }
    }
}
