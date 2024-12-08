﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WarrantyPolicyDAL
    {
        private readonly DBDataContext db;

        public WarrantyPolicyDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các WarrantyPolicies từ cơ sở dữ liệu
        public List<WarrantyPolicy> GetAllWarrantyPolicies()
        {
            return db.WarrantyPolicies.ToList();
        }

        // Thêm WarrantyPolicy vào cơ sở dữ liệu
        public void AddWarrantyPolicy(WarrantyPolicy policy)
        {
            db.WarrantyPolicies.InsertOnSubmit(policy);
            db.SubmitChanges();
        }

        // Cập nhật WarrantyPolicy trong cơ sở dữ liệu
        public void UpdateWarrantyPolicy(WarrantyPolicy policy)
        {
            var existingPolicy = db.WarrantyPolicies.SingleOrDefault(p => p.id == policy.id);
            if (existingPolicy != null)
            {
                existingPolicy.ImgProfile = policy.ImgProfile;
                existingPolicy.WarrantyProvider = policy.WarrantyProvider;
                existingPolicy.WarrantyConditions = policy.WarrantyConditions;
                existingPolicy.PolicyContent = policy.PolicyContent;
                existingPolicy.DeletedAt = policy.DeletedAt;
                existingPolicy.CreatedBy = policy.CreatedBy;
                existingPolicy.DeletedBy = policy.DeletedBy;
                existingPolicy.UpdatedBy = policy.UpdatedBy;
                existingPolicy.IsDeleted = policy.IsDeleted;
                existingPolicy.createdAt = policy.createdAt;
                existingPolicy.updatedAt = policy.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("WarrantyPolicy not found");
            }
        }

        // Xóa WarrantyPolicy khỏi cơ sở dữ liệu
        public void DeleteWarrantyPolicy(int policyId)
        {
            var policy = db.WarrantyPolicies.SingleOrDefault(p => p.id == policyId);
            if (policy != null)
            {
                db.WarrantyPolicies.DeleteOnSubmit(policy);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("WarrantyPolicy not found");
            }
        }
    }
}
