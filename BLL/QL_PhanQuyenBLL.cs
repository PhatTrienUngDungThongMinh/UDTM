using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QL_PhanQuyenBLL
    {
        private readonly QL_PhanQuyenDAL qlPhanQuyenDAL;

        public QL_PhanQuyenBLL()
        {
            
        }

        // Lấy danh sách tất cả các QL_PhanQuyen
        public List<QL_PhanQuyen> GetAllQL_PhanQuyens()
        {
            return qlPhanQuyenDAL.GetAllQL_PhanQuyens();
        }

        // Thêm một QL_PhanQuyen mới
        public void AddQL_PhanQuyen(QL_PhanQuyen phanQuyen)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (phanQuyen.IDPositions <= 0)
            {
                throw new ArgumentException("ID Position không hợp lệ.");
            }

            if (string.IsNullOrWhiteSpace(phanQuyen.ScreenCode))
            {
                throw new ArgumentException("Screen Code không được để trống.");
            }

            // Thêm QL_PhanQuyen thông qua DAL
            qlPhanQuyenDAL.AddQL_PhanQuyen(phanQuyen);
        }

        // Cập nhật một QL_PhanQuyen hiện có
        public void UpdateQL_PhanQuyen(QL_PhanQuyen phanQuyen)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (phanQuyen.IDPositions <= 0)
            {
                throw new ArgumentException("ID Position không hợp lệ.");
            }

            if (string.IsNullOrWhiteSpace(phanQuyen.ScreenCode))
            {
                throw new ArgumentException("Screen Code không được để trống.");
            }

            // Cập nhật QL_PhanQuyen thông qua DAL
            qlPhanQuyenDAL.UpdateQL_PhanQuyen(phanQuyen);
        }

        // Xóa một QL_PhanQuyen
        public void DeleteQL_PhanQuyen(int positionId, string screenCode)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa QL_PhanQuyen thông qua DAL
            qlPhanQuyenDAL.DeleteQL_PhanQuyen(positionId, screenCode);
        }
    }
}
