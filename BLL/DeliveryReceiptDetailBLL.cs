using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DeliveryReceiptDetailBLL
    {
        private readonly DeliveryReceiptDetailDAL deliveryReceiptDetailDAL = new DeliveryReceiptDetailDAL();

        public DeliveryReceiptDetailBLL()
        {
            
        }

        public List<DeliveryReceiptDetail> GetAllDeliveryReceiptDetails()
        {
            return deliveryReceiptDetailDAL.GetAllDeliveryReceiptDetails();
        }

        public void AddDeliveryReceiptDetail(DeliveryReceiptDetail detail)
        {
            if (detail.Quantity <= 0)
            {
                throw new ArgumentException("Số lượng phải lớn hơn 0.");
            }

            if (detail.UnitPrice < 0)
            {
                throw new ArgumentException("Giá đơn vị không được âm.");
            }

            deliveryReceiptDetailDAL.AddDeliveryReceiptDetail(detail);
        }

        public void UpdateDeliveryReceiptDetail(DeliveryReceiptDetail detail)
        {
            if (detail.Quantity <= 0)
            {
                throw new ArgumentException("Số lượng phải lớn hơn 0.");
            }

            if (detail.UnitPrice < 0)
            {
                throw new ArgumentException("Giá đơn vị không được âm.");
            }

            deliveryReceiptDetailDAL.UpdateDeliveryReceiptDetail(detail);
        }

        public void DeleteDeliveryReceiptDetail(int detailId)
        {
            deliveryReceiptDetailDAL.DeleteDeliveryReceiptDetail(detailId);
        }
    }
}
