using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ImageBLL
    {
        private readonly ImageDAL imageDAL = new ImageDAL();

        public ImageBLL()
        {
            
        }

        public List<Image> GetAllImages()
        {
            return imageDAL.GetAllImages();
        }

        public void AddImage(Image image)
        {
            if (string.IsNullOrWhiteSpace(image.FilePath))
            {
                throw new ArgumentException("Đường dẫn File không được để trống.");
            }

            imageDAL.AddImage(image);
        }

        public void UpdateImage(Image image)
        {
            if (string.IsNullOrWhiteSpace(image.FilePath))
            {
                throw new ArgumentException("Đường dẫn File không được để trống.");
            }

            imageDAL.UpdateImage(image);
        }

        public void DeleteImage(int imageId)
        {

            imageDAL.DeleteImage(imageId);
        }
    }
}
