using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ColorDAL
    {
        private readonly DBDataContext db;

        public ColorDAL( )
        {
            db = new DBDataContext();
        }

        public List<Color> GetAllColors()
        {
            return db.Colors.ToList();
        }

        public void AddColor(Color color)
        {
            db.Colors.InsertOnSubmit(color);
            db.SubmitChanges();
        }

        public void UpdateColor(Color color)
        {
            var existingColor = db.Colors.SingleOrDefault(c => c.id == color.id);
            if (existingColor != null)
            {
                existingColor.ColorName = color.ColorName;
                existingColor.ProductID = color.ProductID;
                existingColor.createdAt = color.createdAt;
                existingColor.updatedAt = color.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Color not found");
            }
        }

        public void DeleteColor(int colorId)
        {
            var color = db.Colors.SingleOrDefault(c => c.id == colorId);
            if (color != null)
            {
                db.Colors.DeleteOnSubmit(color);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Color not found");
            }
        }

    }
}
