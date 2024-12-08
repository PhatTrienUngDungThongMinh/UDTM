using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ImageDAL
    {
        private readonly DBDataContext db;

        public ImageDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các Images từ cơ sở dữ liệu
        public List<Image> GetAllImages()
        {
            return db.Images.ToList();
        }

        // Thêm Image vào cơ sở dữ liệu
        public void AddImage(Image image)
        {
            db.Images.InsertOnSubmit(image);
            db.SubmitChanges();
        }

        // Cập nhật Image trong cơ sở dữ liệu
        public void UpdateImage(Image image)
        {
            var existingImage = db.Images.SingleOrDefault(i => i.id == image.id);
            if (existingImage != null)
            {
                existingImage.ThuTu = image.ThuTu;
                existingImage.ProductID = image.ProductID;
                existingImage.FilePath = image.FilePath;
                existingImage.createdAt = image.createdAt;
                existingImage.updatedAt = image.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Image not found");
            }
        }

        // Xóa Image khỏi cơ sở dữ liệu
        public void DeleteImage(int imageId)
        {
            var image = db.Images.SingleOrDefault(i => i.id == imageId);
            if (image != null)
            {
                db.Images.DeleteOnSubmit(image);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Image not found");
            }
        }
    }
}
