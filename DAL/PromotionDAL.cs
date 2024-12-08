using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PromotionDAL
    {
        private readonly DBDataContext db;

        public PromotionDAL()
        {
            db = new DBDataContext();
        }

        public List<Promotion> GetAllPromotions()
        {
            return db.Promotions.ToList();
        }

        public void AddPromotion(Promotion promotion)
        {
            db.Promotions.InsertOnSubmit(promotion);
            db.SubmitChanges();
        }

        public void UpdatePromotion(Promotion promotion)
        {
            var existingPromotion = db.Promotions.SingleOrDefault(p => p.id == promotion.id);
            if (existingPromotion != null)
            {
                existingPromotion.ImgProfile = promotion.ImgProfile;
                existingPromotion.PromotionName = promotion.PromotionName;
                existingPromotion.DiscountValue = promotion.DiscountValue;
                existingPromotion.Quantity = promotion.Quantity;
                existingPromotion.MinValue = promotion.MinValue;
                existingPromotion.MaxDiscount = promotion.MaxDiscount;
                existingPromotion.Code = promotion.Code;
                existingPromotion.StartDate = promotion.StartDate;
                existingPromotion.EndDate = promotion.EndDate;
                existingPromotion.DeletedAt = promotion.DeletedAt;
                existingPromotion.CreatedBy = promotion.CreatedBy;
                existingPromotion.DeletedBy = promotion.DeletedBy;
                existingPromotion.UpdatedBy = promotion.UpdatedBy;
                existingPromotion.IsDeleted = promotion.IsDeleted;
                existingPromotion.createdAt = promotion.createdAt;
                existingPromotion.updatedAt = promotion.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Promotion not found");
            }
        }

        public void DeletePromotion(int promotionId)
        {
            var promotion = db.Promotions.SingleOrDefault(p => p.id == promotionId);
            if (promotion != null)
            {
                db.Promotions.DeleteOnSubmit(promotion);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Promotion not found");
            }
        }
    }
}
