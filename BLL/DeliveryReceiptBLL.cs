using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DeliveryReceiptBLL
    {
        private readonly DeliveryReceiptDAL deliveryReceiptDAL = new DeliveryReceiptDAL();

        public DeliveryReceiptBLL()
        {
            
        }

        public List<DeliveryReceipt> GetAllDeliveryReceipts()
        {
            return deliveryReceiptDAL.GetAllDeliveryReceipts();
        }

        public void AddDeliveryReceipt(DeliveryReceipt receipt)
        {
            if (receipt.DeliveryDate == default(DateTime))
            {
                throw new ArgumentException("Ngày giao hàng không hợp lệ.");
            }

            deliveryReceiptDAL.AddDeliveryReceipt(receipt);
        }

        public void UpdateDeliveryReceipt(DeliveryReceipt receipt)
        {
            if (receipt.DeliveryDate == default(DateTime))
            {
                throw new ArgumentException("Ngày giao hàng không hợp lệ.");
            }

            deliveryReceiptDAL.UpdateDeliveryReceipt(receipt);
        }

        public void DeleteDeliveryReceipt(int receiptId)
        {
            deliveryReceiptDAL.DeleteDeliveryReceipt(receiptId);
        }
    }
}
