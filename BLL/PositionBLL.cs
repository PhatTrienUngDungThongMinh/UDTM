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
        private readonly PositionDAL positionDAL = new PositionDAL();

        public PositionBLL()
        {
            
        }

        public List<Position> GetAllPositions()
        {
            return positionDAL.GetAllPositions();
        }

        public void AddPosition(Position position)
        {
            if (string.IsNullOrWhiteSpace(position.PositionName))
            {
                throw new ArgumentException("Tên Position không được để trống.");
            }

            positionDAL.AddPosition(position);
        }

        public void UpdatePosition(Position position)
        {
            if (string.IsNullOrWhiteSpace(position.PositionName))
            {
                throw new ArgumentException("Tên Position không được để trống.");
            }

            positionDAL.UpdatePosition(position);
        }

        public void DeletePosition(int positionId)
        {

            positionDAL.DeletePosition(positionId);
        }
    }
}
