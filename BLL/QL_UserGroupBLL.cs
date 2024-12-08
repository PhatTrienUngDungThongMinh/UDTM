using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QL_UserGroupBLL
    {
        private readonly QL_UserGroupDAL qlUserGroupDAL = new QL_UserGroupDAL();

        public QL_UserGroupBLL()
        {
            
        }

        public List<QL_UserGroup> GetAllQL_UserGroups()
        {
            return qlUserGroupDAL.GetAllQL_UserGroups();
        }

        public void AddQL_UserGroup(QL_UserGroup userGroup)
        {
            if (userGroup.IDEmployees <= 0)
            {
                throw new ArgumentException("ID Employee không hợp lệ.");
            }

            if (userGroup.IDPositions <= 0)
            {
                throw new ArgumentException("ID Position không hợp lệ.");
            }

            qlUserGroupDAL.AddQL_UserGroup(userGroup);
        }

        public void UpdateQL_UserGroup(QL_UserGroup userGroup)
        {
            if (userGroup.IDEmployees <= 0)
            {
                throw new ArgumentException("ID Employee không hợp lệ.");
            }

            if (userGroup.IDPositions <= 0)
            {
                throw new ArgumentException("ID Position không hợp lệ.");
            }

            qlUserGroupDAL.UpdateQL_UserGroup(userGroup);
        }

        public void DeleteQL_UserGroup(int employeeId, int positionId)
        {

            qlUserGroupDAL.DeleteQL_UserGroup(employeeId, positionId);
        }
    }
}
