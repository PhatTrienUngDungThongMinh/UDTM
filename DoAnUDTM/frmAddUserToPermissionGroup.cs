using BLL;
using DTO;
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
    public partial class frmAddUserToPermissionGroup : Form
    {
        PositionBLL position = new PositionBLL();
        EmployeeBLL employee = new EmployeeBLL();
        public frmAddUserToPermissionGroup()
        {
            InitializeComponent();
        }

        private void frmAddUserToPermissionGroup_Load(object sender, EventArgs e)
        {
            
            lstPermissionGroups.DataSource = position.GetAllPositions();
            lstPermissionGroups.DisplayMember = "PositionName";
        }

        private void lstPermissionGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPermissionGroups.SelectedItem != null)
            {
                //Position selectedItem = (Position)lstPermissionGroups.SelectedItem;
                //dgvMembers.DataSource = employee.GetEmployeeByIdPosition(selectedItem.id);
                Position selectedItem = (Position)lstPermissionGroups.SelectedItem;

                // Assuming the 'id' is a property of 'position' and GetEmployeeByIdPosition expects an 'id'
                var employees = employee.GetEmployeeByIdPosition(selectedItem.id);

                // Set the data source for dgvMembers (assuming employees is a collection or list)
                dgvMembers.DataSource = employees;
            }
        }
    }
}
