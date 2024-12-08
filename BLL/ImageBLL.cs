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
        private readonly ImageDAL imageDAL;

        public ImageBLL()
        {
            
        }

        // Lấy danh sách tất cả các Images
        public List<Image> GetAllImages()
        {
            return imageDAL.GetAllImages();
        }

        // Thêm một Image mới
        public void AddImage(Image image)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(image.FilePath))
            {
                throw new ArgumentException("Đường dẫn File không được để trống.");
            }

            // Thêm Image thông qua DAL
            imageDAL.AddImage(image);
        }

        // Cập nhật một Image hiện có
        public void UpdateImage(Image image)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(image.FilePath))
            {
                throw new ArgumentException("Đường dẫn File không được để trống.");
            }

            // Cập nhật Image thông qua DAL
            imageDAL.UpdateImage(image);
        }

        // Xóa một Image
        public void DeleteImage(int imageId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa Image thông qua DAL
            imageDAL.DeleteImage(imageId);
        }
    }
}
