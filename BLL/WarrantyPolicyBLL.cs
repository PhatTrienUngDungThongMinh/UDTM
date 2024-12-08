using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class WarrantyPolicyBLL
    {
        private readonly WarrantyPolicyDAL warrantyPolicyDAL;

        public WarrantyPolicyBLL(string connectionString)
        {
            warrantyPolicyDAL = new WarrantyPolicyDAL(connectionString);
        }

        // Lấy danh sách tất cả các WarrantyPolicies
        public List<WarrantyPolicy> GetAllWarrantyPolicies()
        {
            return warrantyPolicyDAL.GetAllWarrantyPolicies();
        }

        // Thêm một WarrantyPolicy mới
        public void AddWarrantyPolicy(WarrantyPolicy policy)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(policy.WarrantyProvider))
            {
                throw new ArgumentException("Nhà cung cấp bảo hành không được để trống.");
            }


            // Thêm WarrantyPolicy thông qua DAL
            warrantyPolicyDAL.AddWarrantyPolicy(policy);
        }

        // Cập nhật một WarrantyPolicy hiện có
        public void UpdateWarrantyPolicy(WarrantyPolicy policy)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(policy.WarrantyProvider))
            {
                throw new ArgumentException("Nhà cung cấp bảo hành không được để trống.");
            }

            // Cập nhật WarrantyPolicy thông qua DAL
            warrantyPolicyDAL.UpdateWarrantyPolicy(policy);
        }

        // Xóa một WarrantyPolicy
        public void DeleteWarrantyPolicy(int policyId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa WarrantyPolicy thông qua DAL
            warrantyPolicyDAL.DeleteWarrantyPolicy(policyId);
        }
    }
}
