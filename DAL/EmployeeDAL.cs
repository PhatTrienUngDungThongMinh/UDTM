using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeDAL
    {
        private readonly DBDataContext db;

        public EmployeeDAL()
        {
            db = new DBDataContext();
        }

        public List<Employee> GetAllEmployees()
        {
            return db.Employees.ToList();
        }
        public Employee GetEmployeeByIdPosition(int id)
        {
            return db.Employees.FirstOrDefault(e => e.PositionID == id);
        }
        public void AddEmployee(Employee employee)
        {
            db.Employees.InsertOnSubmit(employee);
            db.SubmitChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            var existingEmployee = db.Employees.SingleOrDefault(e => e.id == employee.id);
            if (existingEmployee != null)
            {
                existingEmployee.Username = employee.Username;
                existingEmployee.Password = employee.Password;
                existingEmployee.PositionID = employee.PositionID;
                existingEmployee.FullName = employee.FullName;
                existingEmployee.DateOfBirth = employee.DateOfBirth;
                existingEmployee.Gender = employee.Gender;
                existingEmployee.Address = employee.Address;
                existingEmployee.Email = employee.Email;
                existingEmployee.PhoneNumber = employee.PhoneNumber;
                existingEmployee.IsActive = employee.IsActive;
                existingEmployee.DeletedAt = employee.DeletedAt;
                existingEmployee.CreatedBy = employee.CreatedBy;
                existingEmployee.DeletedBy = employee.DeletedBy;
                existingEmployee.UpdatedBy = employee.UpdatedBy;
                existingEmployee.IsDeleted = employee.IsDeleted;
                existingEmployee.createdAt = employee.createdAt;
                existingEmployee.updatedAt = employee.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Employee not found");
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            var employee = db.Employees.SingleOrDefault(e => e.id == employeeId);
            if (employee != null)
            {
                db.Employees.DeleteOnSubmit(employee);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Employee not found");
            }
        }
    }
}
