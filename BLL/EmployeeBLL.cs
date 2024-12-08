using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeBLL
    {
        private readonly EmployeeDAL employeeDAL;

        public EmployeeBLL()
        {
            
        }

        // Lấy danh sách tất cả các Employees
        public List<Employee> GetAllEmployees()
        {
            return employeeDAL.GetAllEmployees();
        }

        // Thêm một Employee mới
        public void AddEmployee(Employee employee)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(employee.Username))
            {
                throw new ArgumentException("Username không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(employee.Password))
            {
                throw new ArgumentException("Password không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(employee.FullName))
            {
                throw new ArgumentException("Họ và Tên không được để trống.");
            }

            // Thêm Employee thông qua DAL
            employeeDAL.AddEmployee(employee);
        }

        // Cập nhật một Employee hiện có
        public void UpdateEmployee(Employee employee)
        {
            // Kiểm tra hợp lệ dữ liệu
            if (string.IsNullOrWhiteSpace(employee.Username))
            {
                throw new ArgumentException("Username không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(employee.Password))
            {
                throw new ArgumentException("Password không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(employee.FullName))
            {
                throw new ArgumentException("Họ và Tên không được để trống.");
            }

            // Cập nhật Employee thông qua DAL
            employeeDAL.UpdateEmployee(employee);
        }

        // Xóa một Employee
        public void DeleteEmployee(int employeeId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa

            // Xóa Employee thông qua DAL
            employeeDAL.DeleteEmployee(employeeId);
        }
    }
}
