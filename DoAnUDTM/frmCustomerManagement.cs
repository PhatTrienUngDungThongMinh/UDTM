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
    public partial class frmCustomerManagement : Form
    {
        CustomerBLL customer = new CustomerBLL();
        public frmCustomerManagement()
        {
            InitializeComponent();
        }

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            DsKhachHang.DataSource = customer.GetAllCustomers();
            DsKhachHang.CellClick += DsKhachHang_CellClick; 
        }
        private void DsKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DsKhachHang.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells["id"].Value != DBNull.Value ? row.Cells["id"].Value.ToString() : string.Empty;
                txtSDT.Text = row.Cells["PhoneNumber"].Value != DBNull.Value ? row.Cells["PhoneNumber"].Value.ToString() : string.Empty;
                txtTen.Text = row.Cells["CustomerName"].Value != DBNull.Value ? row.Cells["CustomerName"].Value.ToString() : string.Empty;
                txtEmail.Text = row.Cells["Email"].Value != DBNull.Value ? row.Cells["Email"].Value.ToString() : string.Empty;

                if (row.Cells["BirthDate"].Value != DBNull.Value && row.Cells["BirthDate"].Value != null)
                {
                    txtNgaySinh.Text = row.Cells["BirthDate"].Value.ToString();
                }
                else
                {
                    txtNgaySinh.Text = string.Empty;
                }
                if (row.Cells["createdAt"].Value != DBNull.Value && row.Cells["createdAt"].Value != null)
                {
                    txtNgayTao.Text = row.Cells["createdAt"].Value.ToString();
                }
                else
                {
                    txtNgayTao.Text = string.Empty;
                }

                if (row.Cells["updatedAt"].Value != DBNull.Value && row.Cells["updatedAt"].Value != null)
                {

                    txtNgayUpdate.Text = row.Cells["updatedAt"].Value.ToString();
                }
                else
                {
                    txtNgayUpdate.Text = string.Empty;
                }
                rdoNam.Checked = row.Cells["Gender"].Value != DBNull.Value && row.Cells["Gender"].Value.ToString() == "Nam";
                rdoNu.Checked = row.Cells["Gender"].Value != DBNull.Value && row.Cells["Gender"].Value.ToString() == "Nữ";

                if (row.Cells["IsActive"].Value != DBNull.Value)
                {
                    int isActive = Convert.ToInt32(row.Cells["IsActive"].Value); 
                    txtActive.Text = isActive == 1 ? "Còn hoạt động" : "Không hoạt động";
                }
                else
                {
                    txtActive.Text = "Không xác định";  
                }

            }
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKH.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng để khóa.");
                    return;
                }
                var customerId = txtMaKH.Text;
                var existingCustomer = customer.GetAllCustomers().FirstOrDefault(c => c.id == customerId);

                if (!existingCustomer.IsActive)
                {
                    MessageBox.Show("Tài khoản đã bị khóa rồi.");
                    return;
                }

                var result = MessageBox.Show("Bạn có muốn khóa tài khoản này không?", "Xác nhận khóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    existingCustomer.IsActive = false;
                    existingCustomer.updatedAt = DateTime.Now;
                    customer.UpdateCustomer(existingCustomer);

                    MessageBox.Show("Khóa tài khoản thành công!");
                    LoadCustomers(); 
                }
                else
                {
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                var result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin khách hàng này không?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool isActive = false;
                    if (!string.IsNullOrWhiteSpace(txtActive.Text))
                    {
                        isActive = txtActive.Text == "1";
                    }

                    var updatedCustomer = new DTO.Customer
                    {
                        id = txtMaKH.Text,
                        CustomerName = txtTen.Text,
                        PhoneNumber = txtSDT.Text,
                        Email = txtEmail.Text,
                        BirthDate = DateTime.TryParse(txtNgaySinh.Text, out DateTime birthDate) ? birthDate : (DateTime?)null,
                        Gender = rdoNam.Checked ? "Nam" : "Nữ",
                        IsActive = isActive,
                        updatedAt = DateTime.Now
                    };

                    var existingCustomer = customer.GetAllCustomers().FirstOrDefault(c => c.id == updatedCustomer.id);

                    if (existingCustomer != null)
                    {
                        updatedCustomer.createdAt = existingCustomer.createdAt;
                    }
                    customer.UpdateCustomer(updatedCustomer);
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
                    LoadCustomers();
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
                if (string.IsNullOrWhiteSpace(txtMaKH.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng để xóa.", "Thông báo");
                    return;
                }
                DialogResult confirm = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa khách hàng này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    var customerId = txtMaKH.Text;
                    customer.DeleteCustomer(customerId);
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo");
                    LoadCustomers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi");
            }
        }


        private void btnMo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKH.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng để mở khóa.");
                    return;
                }

                var customerId = txtMaKH.Text;
                var existingCustomer = customer.GetAllCustomers().FirstOrDefault(c => c.id == customerId);

                if (existingCustomer.IsActive)
                {
                    MessageBox.Show("Tài khoản đã hoạt động rồi.");
                    return;
                }
                var result = MessageBox.Show("Bạn có muốn mở khóa tài khoản này không?", "Xác nhận mở tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    existingCustomer.IsActive = true;
                    existingCustomer.updatedAt = DateTime.Now;
                    customer.UpdateCustomer(existingCustomer);

                    MessageBox.Show("Mở tài khoản thành công!");
                    LoadCustomers(); 
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }


    }
}
