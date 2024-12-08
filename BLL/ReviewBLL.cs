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
        private readonly ReviewDAL reviewDAL = new ReviewDAL();

        public ReviewBLL()
        {
            
        }

        public List<Review> GetAllReviews()
        {
            return reviewDAL.GetAllReviews();
        }

        public void AddReview(Review review)
        {
            if (string.IsNullOrWhiteSpace(review.ReviewContent))
            {
                throw new ArgumentException("Nội dung Review không được để trống.");
            }

            if (review.RatingLevel < 1 || review.RatingLevel > 5)
            {
                throw new ArgumentException("RatingLevel phải nằm trong khoảng từ 1 đến 5.");
            }

            reviewDAL.AddReview(review);
        }

        public void UpdateReview(Review review)
        {
            if (string.IsNullOrWhiteSpace(review.ReviewContent))
            {
                throw new ArgumentException("Nội dung Review không được để trống.");
            }

            if (review.RatingLevel < 1 || review.RatingLevel > 5)
            {
                throw new ArgumentException("RatingLevel phải nằm trong khoảng từ 1 đến 5.");
            }

            reviewDAL.UpdateReview(review);
        }

        public void DeleteReview(int reviewId)
        {

            reviewDAL.DeleteReview(reviewId);
        }
    }
}
