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
        private readonly QL_PhanQuyenDAL qlPhanQuyenDAL = new QL_PhanQuyenDAL();

        public QL_PhanQuyenBLL()
        {
            
        }

        public List<QL_PhanQuyen> GetAllQL_PhanQuyens()
        {
            return qlPhanQuyenDAL.GetAllQL_PhanQuyens();
        }

        public void AddQL_PhanQuyen(QL_PhanQuyen phanQuyen)
        {
            if (phanQuyen.IDPositions <= 0)
            {
                throw new ArgumentException("ID Position không hợp lệ.");
            }

            if (string.IsNullOrWhiteSpace(phanQuyen.ScreenCode))
            {
                throw new ArgumentException("Screen Code không được để trống.");
            }

            qlPhanQuyenDAL.AddQL_PhanQuyen(phanQuyen);
        }

        public void UpdateQL_PhanQuyen(QL_PhanQuyen phanQuyen)
        {
            if (phanQuyen.IDPositions <= 0)
            {
                throw new ArgumentException("ID Position không hợp lệ.");
            }

            if (string.IsNullOrWhiteSpace(phanQuyen.ScreenCode))
            {
                throw new ArgumentException("Screen Code không được để trống.");
            }

            qlPhanQuyenDAL.UpdateQL_PhanQuyen(phanQuyen);
        }

        public void DeleteQL_PhanQuyen(int positionId, string screenCode)
        {

            qlPhanQuyenDAL.DeleteQL_PhanQuyen(positionId, screenCode);
        }
    }
}
