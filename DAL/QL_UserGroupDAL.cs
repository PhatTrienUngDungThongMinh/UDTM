using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QL_UserGroupDAL
    {
        private readonly DBDataContext db;

        public QL_UserGroupDAL()
        {
            db = new DBDataContext();
        }

        public List<QL_UserGroup> GetAllQL_UserGroups()
        {
            return db.QL_UserGroups.ToList();
        }

        public void AddQL_UserGroup(QL_UserGroup userGroup)
        {
            db.QL_UserGroups.InsertOnSubmit(userGroup);
            db.SubmitChanges();
        }

        public void UpdateQL_UserGroup(QL_UserGroup userGroup)
        {
            var existingUserGroup = db.QL_UserGroups.SingleOrDefault(ug => ug.IDEmployees == userGroup.IDEmployees && ug.IDPositions == userGroup.IDPositions);
            if (existingUserGroup != null)
            {
                existingUserGroup.Note = userGroup.Note;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("QL_UserGroup not found");
            }
        }

        public void DeleteQL_UserGroup(int employeeId, int positionId)
        {
            var userGroup = db.QL_UserGroups.SingleOrDefault(ug => ug.IDEmployees == employeeId && ug.IDPositions == positionId);
            if (userGroup != null)
            {
                db.QL_UserGroups.DeleteOnSubmit(userGroup);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("QL_UserGroup not found");
            }
        }
    }
}
