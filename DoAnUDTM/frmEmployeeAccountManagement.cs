using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnUDTM
{
    public partial class frmEmployeeAccountManagement : Form
    {
        EmployeeBLL employee = new EmployeeBLL();
        public frmEmployeeAccountManagement()
        {
            InitializeComponent();
        }

        private void frmEmployeeAccountManagement_Load(object sender, EventArgs e)
        {
            DsNhanVien.DataSource = employee.GetAllEmployees();
        }
    }
}
