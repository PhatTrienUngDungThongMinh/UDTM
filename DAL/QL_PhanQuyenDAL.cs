using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QL_PhanQuyenDAL
    {
        private readonly DBDataContext db;

        public QL_PhanQuyenDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các QL_PhanQuyen từ cơ sở dữ liệu
        public List<QL_PhanQuyen> GetAllQL_PhanQuyens()
        {
            return db.QL_PhanQuyens.ToList();
        }

        // Thêm QL_PhanQuyen vào cơ sở dữ liệu
        public void AddQL_PhanQuyen(QL_PhanQuyen phanQuyen)
        {
            db.QL_PhanQuyens.InsertOnSubmit(phanQuyen);
            db.SubmitChanges();
        }

        // Cập nhật QL_PhanQuyen trong cơ sở dữ liệu
        public void UpdateQL_PhanQuyen(QL_PhanQuyen phanQuyen)
        {
            var existingPhanQuyen = db.QL_PhanQuyens.SingleOrDefault(q => q.IDPositions == phanQuyen.IDPositions && q.ScreenCode == phanQuyen.ScreenCode);
            if (existingPhanQuyen != null)
            {
                existingPhanQuyen.HasPermission = phanQuyen.HasPermission;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("QL_PhanQuyen not found");
            }
        }

        // Xóa QL_PhanQuyen khỏi cơ sở dữ liệu
        public void DeleteQL_PhanQuyen(int positionId, string screenCode)
        {
            var phanQuyen = db.QL_PhanQuyens.SingleOrDefault(q => q.IDPositions == positionId && q.ScreenCode == screenCode);
            if (phanQuyen != null)
            {
                db.QL_PhanQuyens.DeleteOnSubmit(phanQuyen);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("QL_PhanQuyen not found");
            }
        }
    }
}
