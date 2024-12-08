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
        private readonly QL_UserGroupDAL qlUserGroupDAL;

        public QL_UserGroupBLL(string connectionString)
        {
            qlUserGroupDAL = new QL_UserGroupDAL(connectionString);
        }

        // Lấy danh sách tất cả các QL_UserGroups
        public List<QL_UserGroup> GetAllQL_UserGroups()
        {
            return qlUserGroupDAL.GetAllQL_UserGroups();
        }

        // Thêm một QL_UserGroup mới
        public void AddQL_UserGroup(QL_UserGroup userGroup)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (userGroup.IDEmployees <= 0)
            {
                throw new ArgumentException("ID Employee không hợp lệ.");
            }

            if (userGroup.IDPositions <= 0)
            {
                throw new ArgumentException("ID Position không hợp lệ.");
            }

            // Thêm QL_UserGroup thông qua DAL
            qlUserGroupDAL.AddQL_UserGroup(userGroup);
        }

        // Cập nhật một QL_UserGroup hiện có
        public void UpdateQL_UserGroup(QL_UserGroup userGroup)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (userGroup.IDEmployees <= 0)
            {
                throw new ArgumentException("ID Employee không hợp lệ.");
            }

            if (userGroup.IDPositions <= 0)
            {
                throw new ArgumentException("ID Position không hợp lệ.");
            }

            // Cập nhật QL_UserGroup thông qua DAL
            qlUserGroupDAL.UpdateQL_UserGroup(userGroup);
        }

        // Xóa một QL_UserGroup
        public void DeleteQL_UserGroup(int employeeId, int positionId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa QL_UserGroup thông qua DAL
            qlUserGroupDAL.DeleteQL_UserGroup(employeeId, positionId);
        }
    }
}
