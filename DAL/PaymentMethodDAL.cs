﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PaymentMethodDAL
    {
        private readonly DBDataContext db;

        public PaymentMethodDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các PaymentMethods từ cơ sở dữ liệu
        public List<PaymentMethod> GetAllPaymentMethods()
        {
            return db.PaymentMethods.ToList();
        }

        // Thêm PaymentMethod vào cơ sở dữ liệu
        public void AddPaymentMethod(PaymentMethod paymentMethod)
        {
            db.PaymentMethods.InsertOnSubmit(paymentMethod);
            db.SubmitChanges();
        }

        // Cập nhật PaymentMethod trong cơ sở dữ liệu
        public void UpdatePaymentMethod(PaymentMethod paymentMethod)
        {
            var existingPaymentMethod = db.PaymentMethods.SingleOrDefault(pm => pm.id == paymentMethod.id);
            if (existingPaymentMethod != null)
            {
                existingPaymentMethod.PaymentMethodName = paymentMethod.PaymentMethodName;
                existingPaymentMethod.Description = paymentMethod.Description;
                existingPaymentMethod.Status = paymentMethod.Status;
                existingPaymentMethod.StartDate = paymentMethod.StartDate;
                existingPaymentMethod.EndDate = paymentMethod.EndDate;
                existingPaymentMethod.ApplicableFee = paymentMethod.ApplicableFee;
                existingPaymentMethod.DeletedAt = paymentMethod.DeletedAt;
                existingPaymentMethod.CreatedBy = paymentMethod.CreatedBy;
                existingPaymentMethod.DeletedBy = paymentMethod.DeletedBy;
                existingPaymentMethod.UpdatedBy = paymentMethod.UpdatedBy;
                existingPaymentMethod.createdAt = paymentMethod.createdAt;
                existingPaymentMethod.updatedAt = paymentMethod.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("PaymentMethod not found");
            }
        }

        // Xóa PaymentMethod khỏi cơ sở dữ liệu
        public void DeletePaymentMethod(int paymentMethodId)
        {
            var paymentMethod = db.PaymentMethods.SingleOrDefault(pm => pm.id == paymentMethodId);
            if (paymentMethod != null)
            {
                db.PaymentMethods.DeleteOnSubmit(paymentMethod);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("PaymentMethod not found");
            }
        }
    }
}
