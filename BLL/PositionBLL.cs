using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PositionBLL
    {
        private readonly PositionDAL positionDAL;

        public PositionBLL(string connectionString)
        {
            positionDAL = new PositionDAL(connectionString);
        }

        // Lấy danh sách tất cả các Positions
        public List<Position> GetAllPositions()
        {
            return positionDAL.GetAllPositions();
        }

        // Thêm một Position mới
        public void AddPosition(Position position)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(position.PositionName))
            {
                throw new ArgumentException("Tên Position không được để trống.");
            }

            // Thêm Position thông qua DAL
            positionDAL.AddPosition(position);
        }

        // Cập nhật một Position hiện có
        public void UpdatePosition(Position position)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(position.PositionName))
            {
                throw new ArgumentException("Tên Position không được để trống.");
            }

            // Cập nhật Position thông qua DAL
            positionDAL.UpdatePosition(position);
        }

        // Xóa một Position
        public void DeletePosition(int positionId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa Position thông qua DAL
            positionDAL.DeletePosition(positionId);
        }
    }
}
