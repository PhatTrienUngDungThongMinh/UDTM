using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnUDTM
{
    public partial class frmHome : Form
    {
        bool sildebarExpand = true;
        private Form currentFormChild;
        public frmHome()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void SlidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sildebarExpand)
            {
                // Đặt kích thước của cột đầu tiên (Column 0) của tableLayoutPanel1 thành 100 pixel
                tableLayoutPanel1.ColumnStyles[1].Width -= 10;
                if (tableLayoutPanel1.ColumnStyles[1].Width == 40)
                {
                    sildebarExpand = false;

                    SlidebarTimer.Stop();

                }

            }
            else
            {
                tableLayoutPanel1.ColumnStyles[0].Width += 10;
                if (tableLayoutPanel1.ColumnStyles[0].Width == 210)
                {
                    sildebarExpand = true;
                    SlidebarTimer.Stop();
                }
            }
        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmProductManagement pm=new frmProductManagement();
            OpenChildForm(pm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddUserToPermissionGroup pr = new frmAddUserToPermissionGroup();
            OpenChildForm(pr);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmOrderManagement om=new frmOrderManagement();
            OpenChildForm(om);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmCustomerManagement cm=new frmCustomerManagement();
            OpenChildForm(cm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEmployeeAccountManagement em=new frmEmployeeAccountManagement();
            OpenChildForm(em);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmProductCategorization pc=new frmProductCategorization();
            OpenChildForm(pc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmProductManagement pm= new frmProductManagement();
            OpenChildForm(pm);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login dn = new Login();
                dn.Show();
                this.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmInventoryManagement im = new frmInventoryManagement();
            OpenChildForm(im);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmDiscountAndPromotionManagement dm = new frmDiscountAndPromotionManagement();
            OpenChildForm(dm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPeriodicReport pm = new frmPeriodicReport();
            OpenChildForm(pm);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmRoleManagement rm = new frmRoleManagement();
            OpenChildForm(rm);
        }
    }
}
