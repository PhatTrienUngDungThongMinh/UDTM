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
        private readonly PaymentMethodDAL paymentMethodDAL;

        public PaymentMethodBLL(string connectionString)
        {
            paymentMethodDAL = new PaymentMethodDAL(connectionString);
        }

        // Lấy danh sách tất cả các PaymentMethods
        public List<PaymentMethod> GetAllPaymentMethods()
        {
            return paymentMethodDAL.GetAllPaymentMethods();
        }

        // Thêm một PaymentMethod mới
        public void AddPaymentMethod(PaymentMethod paymentMethod)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(paymentMethod.PaymentMethodName))
            {
                throw new ArgumentException("Tên phương thức thanh toán không được để trống.");
            }

            // Thêm PaymentMethod thông qua DAL
            paymentMethodDAL.AddPaymentMethod(paymentMethod);
        }

        // Cập nhật một PaymentMethod hiện có
        public void UpdatePaymentMethod(PaymentMethod paymentMethod)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(paymentMethod.PaymentMethodName))
            {
                throw new ArgumentException("Tên phương thức thanh toán không được để trống.");
            }

            // Cập nhật PaymentMethod thông qua DAL
            paymentMethodDAL.UpdatePaymentMethod(paymentMethod);
        }

        // Xóa một PaymentMethod
        public void DeletePaymentMethod(int paymentMethodId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa PaymentMethod thông qua DAL
            paymentMethodDAL.DeletePaymentMethod(paymentMethodId);
        }
    }
}
