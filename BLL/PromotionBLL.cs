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
        private readonly PromotionDAL promotionDAL = new PromotionDAL();

        public PromotionBLL()
        {
            
        }

        public List<Promotion> GetAllPromotions()
        {
            return promotionDAL.GetAllPromotions();
        }

        public void AddPromotion(Promotion promotion)
        {
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

            promotionDAL.AddPromotion(promotion);
        }

        public void UpdatePromotion(Promotion promotion)
        {
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

            promotionDAL.UpdatePromotion(promotion);
        }

        public void DeletePromotion(int promotionId)
        {

            promotionDAL.DeletePromotion(promotionId);
        }
    }
}
