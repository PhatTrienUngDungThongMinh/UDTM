using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PaymentMethodBLL
    {
        private readonly PaymentMethodDAL paymentMethodDAL = new PaymentMethodDAL();

        public PaymentMethodBLL()
        {
            
        }

        public List<PaymentMethod> GetAllPaymentMethods()
        {
            return paymentMethodDAL.GetAllPaymentMethods();
        }

        public void AddPaymentMethod(PaymentMethod paymentMethod)
        {
            if (string.IsNullOrWhiteSpace(paymentMethod.PaymentMethodName))
            {
                throw new ArgumentException("Tên phương thức thanh toán không được để trống.");
            }

            paymentMethodDAL.AddPaymentMethod(paymentMethod);
        }

        public void UpdatePaymentMethod(PaymentMethod paymentMethod)
        {
            if (string.IsNullOrWhiteSpace(paymentMethod.PaymentMethodName))
            {
                throw new ArgumentException("Tên phương thức thanh toán không được để trống.");
            }

            paymentMethodDAL.UpdatePaymentMethod(paymentMethod);
        }

        public void DeletePaymentMethod(int paymentMethodId)
        {

            paymentMethodDAL.DeletePaymentMethod(paymentMethodId);
        }
    }
}
