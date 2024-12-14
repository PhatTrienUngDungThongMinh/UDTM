using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace DoAnUDTM
{
    public partial class frmWarrantyPolicies : Form
    {
        WarrantyPolicyBLL policyBLL=new WarrantyPolicyBLL();
        public frmWarrantyPolicies()
        {
            InitializeComponent();
        }

        private void frmWarrantyPolicies_Load(object sender, EventArgs e)
        {
            LoadWarranty();
        }
        private void LoadWarranty()
        {
            dataGridView1.DataSource = policyBLL.GetAllWarrantyPolicies();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txtMaBh.Text = selectedRow.Cells["id"].Value?.ToString();
                txtNhaCC.Text = selectedRow.Cells["WarrantyProvider"].Value?.ToString();
                txtDieukien.Text = selectedRow.Cells["WarrantyConditions"].Value?.ToString();
                txtNgayTao.Text = selectedRow.Cells["createdAt"].Value?.ToString();
                txtNgayUpdate.Text = selectedRow.Cells["updatedAt"].Value?.ToString();
                txtNoidung.Text = selectedRow.Cells["PolicyContent"].Value?.ToString();
            }
        }

        private void btnnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn thêm bảo hành này không?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(txtNhaCC.Text))
                    {
                        MessageBox.Show("Nhà cung cấp không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return ;
                    }

                    if (string.IsNullOrWhiteSpace(txtNoidung.Text))
                    {
                        MessageBox.Show("Nội dung chính sách không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return ;
                    }

                    if (string.IsNullOrWhiteSpace(txtDieukien.Text))
                    {
                        MessageBox.Show("Điều kiện bảo hành không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return ;
                    }
                    var newPolicy = new WarrantyPolicy
                    {
                        WarrantyProvider = txtNhaCC.Text.Trim(),
                        WarrantyConditions = txtDieukien.Text.Trim(),
                        PolicyContent = txtNoidung.Text.Trim(),
                        createdAt = DateTime.Now,
                        updatedAt = DateTime.Now
                    };

                    policyBLL.AddWarrantyPolicy(newPolicy);
                    MessageBox.Show("Thêm chính sách bảo hành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadWarranty(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaBh.Text))
                {
                    MessageBox.Show("Vui lòng chọn chính sách cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int policyId = int.Parse(txtMaBh.Text); 
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa chính sách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    policyBLL.DeleteWarrantyPolicy(policyId);
                    MessageBox.Show("Xóa chính sách bảo hành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadWarranty(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaBh.Text))
                {
                    MessageBox.Show("Vui lòng chọn chính sách cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn sửa chính sách này?",
                                              "Xác nhận",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    int policyId = int.Parse(txtMaBh.Text);

                    var updatedPolicy = new WarrantyPolicy
                    {
                        id = policyId,
                        WarrantyProvider = txtNhaCC.Text.Trim(),
                        WarrantyConditions = txtDieukien.Text.Trim(),
                        PolicyContent = txtNoidung.Text.Trim(),
                        createdAt = DateTime.Parse(txtNgayTao.Text),
                        updatedAt = DateTime.Now
                    };

                    policyBLL.UpdateWarrantyPolicy(updatedPolicy);
                    MessageBox.Show("Cập nhật chính sách bảo hành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadWarranty();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
