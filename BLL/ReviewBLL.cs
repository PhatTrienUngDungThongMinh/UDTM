using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReviewBLL
    {
        private readonly ReviewDAL reviewDAL;

        public ReviewBLL()
        {
            
        }

        // Lấy danh sách tất cả các Reviews
        public List<Review> GetAllReviews()
        {
            return reviewDAL.GetAllReviews();
        }

        // Thêm một Review mới
        public void AddReview(Review review)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(review.ReviewContent))
            {
                throw new ArgumentException("Nội dung Review không được để trống.");
            }

            if (review.RatingLevel < 1 || review.RatingLevel > 5)
            {
                throw new ArgumentException("RatingLevel phải nằm trong khoảng từ 1 đến 5.");
            }

            // Thêm Review thông qua DAL
            reviewDAL.AddReview(review);
        }

        // Cập nhật một Review hiện có
        public void UpdateReview(Review review)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(review.ReviewContent))
            {
                throw new ArgumentException("Nội dung Review không được để trống.");
            }

            if (review.RatingLevel < 1 || review.RatingLevel > 5)
            {
                throw new ArgumentException("RatingLevel phải nằm trong khoảng từ 1 đến 5.");
            }

            // Cập nhật Review thông qua DAL
            reviewDAL.UpdateReview(review);
        }

        // Xóa một Review
        public void DeleteReview(int reviewId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa Review thông qua DAL
            reviewDAL.DeleteReview(reviewId);
        }
    }
}
