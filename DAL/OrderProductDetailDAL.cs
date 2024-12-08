using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderProductDetailDAL
    {
        private readonly DBDataContext db;

        public OrderProductDetailDAL()
        {
            db = new DBDataContext();
        }

        public List<OrderProductDetail> GetAllOrderProductDetails()
        {
            return db.OrderProductDetails.ToList();
        }

        public void AddOrderProductDetail(OrderProductDetail orderProductDetail)
        {
            db.OrderProductDetails.InsertOnSubmit(orderProductDetail);
            db.SubmitChanges();
        }

        public void UpdateOrderProductDetail(OrderProductDetail orderProductDetail)
        {
            var existingDetail = db.OrderProductDetails.SingleOrDefault(op => op.id == orderProductDetail.id);
            if (existingDetail != null)
            {
                existingDetail.OrderID = orderProductDetail.OrderID;
                existingDetail.ProductID = orderProductDetail.ProductID;
                existingDetail.UnitPrice = orderProductDetail.UnitPrice;
                existingDetail.Quantity = orderProductDetail.Quantity;
                existingDetail.Notes = orderProductDetail.Notes;
                existingDetail.createdAt = orderProductDetail.createdAt;
                existingDetail.updatedAt = orderProductDetail.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("OrderProductDetail not found");
            }
        }

        public void DeleteOrderProductDetail(int detailId)
        {
            var detail = db.OrderProductDetails.SingleOrDefault(op => op.id == detailId);
            if (detail != null)
            {
                db.OrderProductDetails.DeleteOnSubmit(detail);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("OrderProductDetail not found");
            }
        }
    }
}
