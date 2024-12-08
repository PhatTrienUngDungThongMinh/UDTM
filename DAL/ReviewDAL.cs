﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReviewDAL
    {
        private readonly DBDataContext db;

        public ReviewDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các Reviews từ cơ sở dữ liệu
        public List<Review> GetAllReviews()
        {
            return db.Reviews.ToList();
        }

        // Thêm Review vào cơ sở dữ liệu
        public void AddReview(Review review)
        {
            db.Reviews.InsertOnSubmit(review);
            db.SubmitChanges();
        }

        // Cập nhật Review trong cơ sở dữ liệu
        public void UpdateReview(Review review)
        {
            var existingReview = db.Reviews.SingleOrDefault(r => r.id == review.id);
            if (existingReview != null)
            {
                existingReview.ReviewContent = review.ReviewContent;
                existingReview.RatingLevel = review.RatingLevel;
                existingReview.ReviewDate = review.ReviewDate;
                existingReview.ProductID = review.ProductID;
                existingReview.CustomerID = review.CustomerID;
                existingReview.createdAt = review.createdAt;
                existingReview.updatedAt = review.updatedAt;
                existingReview.Bought = review.Bought;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Review not found");
            }
        }

        // Xóa Review khỏi cơ sở dữ liệu
        public void DeleteReview(int reviewId)
        {
            var review = db.Reviews.SingleOrDefault(r => r.id == reviewId);
            if (review != null)
            {
                db.Reviews.DeleteOnSubmit(review);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Review not found");
            }
        }
    }
}
