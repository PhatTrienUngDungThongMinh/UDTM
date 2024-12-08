using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PositionDAL
    {
        private readonly DBDataContext db;

        public PositionDAL(string connectionString)
        {
            db = new DBDataContext(connectionString);
        }

        // Lấy danh sách các Positions từ cơ sở dữ liệu
        public List<Position> GetAllPositions()
        {
            return db.Positions.ToList();
        }

        // Thêm Position vào cơ sở dữ liệu
        public void AddPosition(Position position)
        {
            db.Positions.InsertOnSubmit(position);
            db.SubmitChanges();
        }

        // Cập nhật Position trong cơ sở dữ liệu
        public void UpdatePosition(Position position)
        {
            var existingPosition = db.Positions.SingleOrDefault(p => p.id == position.id);
            if (existingPosition != null)
            {
                existingPosition.PositionName = position.PositionName;
                existingPosition.createdAt = position.createdAt;
                existingPosition.updatedAt = position.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Position not found");
            }
        }

        // Xóa Position khỏi cơ sở dữ liệu
        public void DeletePosition(int positionId)
        {
            var position = db.Positions.SingleOrDefault(p => p.id == positionId);
            if (position != null)
            {
                db.Positions.DeleteOnSubmit(position);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Position not found");
            }
        }
    }
}
