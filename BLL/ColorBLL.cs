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
        private readonly ColorDAL colorDAL = new ColorDAL();

        public ColorBLL()
        {
           
        }

        public List<Color> GetAllColors()
        {
            return colorDAL.GetAllColors();
        }

        public void AddColor(Color color)
        {
            if (string.IsNullOrWhiteSpace(color.ColorName))
            {
                throw new ArgumentException("Tên Color không được để trống.");
            }

            colorDAL.AddColor(color);
        }

        public void UpdateColor(Color color)
        {
            if (string.IsNullOrWhiteSpace(color.ColorName))
            {
                throw new ArgumentException("Tên Color không được để trống.");
            }

            colorDAL.UpdateColor(color);
        }

        public void DeleteColor(int colorId)
        {
            colorDAL.DeleteColor(colorId);
        }

    } 
}
