using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PromotionBLL
    {
        private readonly PromotionDAL promotionDAL;

        public PromotionBLL(string connectionString)
        {
            promotionDAL = new PromotionDAL(connectionString);
        }

        // Lấy danh sách tất cả các Promotions
        public List<Promotion> GetAllPromotions()
        {
            return promotionDAL.GetAllPromotions();
        }

        // Thêm một Promotion mới
        public void AddPromotion(Promotion promotion)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(promotion.PromotionName))
            {
                throw new ArgumentException("Tên Promotion không được để trống.");
            }

            if (promotion.DiscountValue < 0)
            {
                throw new ArgumentException("Giá trị giảm giá không được âm.");
            }

            if (promotion.Quantity < 0)
            {
                throw new ArgumentException("Số lượng không được âm.");
            }

            if (promotion.StartDate > promotion.EndDate)
            {
                throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.");
            }

            // Thêm Promotion thông qua DAL
            promotionDAL.AddPromotion(promotion);
        }

        // Cập nhật một Promotion hiện có
        public void UpdatePromotion(Promotion promotion)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(promotion.PromotionName))
            {
                throw new ArgumentException("Tên Promotion không được để trống.");
            }

            if (promotion.DiscountValue < 0)
            {
                throw new ArgumentException("Giá trị giảm giá không được âm.");
            }

            if (promotion.Quantity < 0)
            {
                throw new ArgumentException("Số lượng không được âm.");
            }

            if (promotion.StartDate > promotion.EndDate)
            {
                throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.");
            }

            // Cập nhật Promotion thông qua DAL
            promotionDAL.UpdatePromotion(promotion);
        }

        // Xóa một Promotion
        public void DeletePromotion(int promotionId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa Promotion thông qua DAL
            promotionDAL.DeletePromotion(promotionId);
        }
    }
}
