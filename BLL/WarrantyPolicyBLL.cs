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
        private readonly WarrantyPolicyDAL warrantyPolicyDAL = new WarrantyPolicyDAL();

        public WarrantyPolicyBLL()
        {
            
        }

        public List<WarrantyPolicy> GetAllWarrantyPolicies()
        {
            return warrantyPolicyDAL.GetAllWarrantyPolicies();
        }

        public void AddWarrantyPolicy(WarrantyPolicy policy)
        {
            if (string.IsNullOrWhiteSpace(policy.WarrantyProvider))
            {
                throw new ArgumentException("Nhà cung cấp bảo hành không được để trống.");
            }


            warrantyPolicyDAL.AddWarrantyPolicy(policy);
        }

        public void UpdateWarrantyPolicy(WarrantyPolicy policy)
        {
            if (string.IsNullOrWhiteSpace(policy.WarrantyProvider))
            {
                throw new ArgumentException("Nhà cung cấp bảo hành không được để trống.");
            }

            warrantyPolicyDAL.UpdateWarrantyPolicy(policy);
        }

        public void DeleteWarrantyPolicy(int policyId)
        {
            warrantyPolicyDAL.DeleteWarrantyPolicy(policyId);
        }
    }
}
