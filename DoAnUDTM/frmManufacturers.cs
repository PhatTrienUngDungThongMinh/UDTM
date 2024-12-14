using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace DoAnUDTM
{
    public partial class frmManufacturers : Form
    {
        ManufacturerBLL man = new ManufacturerBLL();
        public frmManufacturers()
        {
            InitializeComponent();
        }

        private void frmManufacturers_Load(object sender, EventArgs e)
        {
            LoadManufacturer();
        }
        private void LoadManufacturer()
        {
            dataGridView1.DataSource = man.GetAllManufacturers();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtNhaSX.Text = row.Cells["id"].Value.ToString();
                txtTenSX.Text = row.Cells["ManufacturerName"].Value.ToString();
                txtNgayTao.Text = row.Cells["createdAt"].Value.ToString();
                txtNgayUpdate.Text = row.Cells["updatedAt"].Value.ToString();
            }
        }

        private void btnnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn thêm hãng sản xuất này không?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(txtTenSX.Text))
                    {
                        MessageBox.Show("Tên hãng sản xuất không được để trống.");
                        return;
                    }

                    var newManufacturer = new DTO.Manufacturer
                    {
                        ManufacturerName = txtTenSX.Text,
                        createdAt = DateTime.Now,
                        updatedAt = DateTime.Now
                    };

                    man.AddManufacturer(newManufacturer);
                    MessageBox.Show("Thêm hãng sản xuất thành công!");
                    LoadManufacturer();
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
                if (string.IsNullOrWhiteSpace(txtNhaSX.Text))
                {
                    MessageBox.Show("Chưa chọn hãng sản xuất để xóa.");
                    return;
                }

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hãng sản xuất này không?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int manufacturerId = Convert.ToInt32(txtNhaSX.Text);
                    try
                    {
                        man.DeleteManufacturer(manufacturerId);
                        MessageBox.Show("Xóa hãng sản xuất thành công!");
                        LoadManufacturer();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}");
                    }
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
                if (string.IsNullOrWhiteSpace(txtNhaSX.Text) || string.IsNullOrWhiteSpace(txtTenSX.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhập tên hãng sản xuất.");
                    return;
                }

                int manufacturerId = Convert.ToInt32(txtNhaSX.Text);

                var result = MessageBox.Show("Bạn có chắc chắn muốn sửa hãng sản xuất này không?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var currentManufacturer = man.GetAllManufacturers().FirstOrDefault(c => c.id == manufacturerId);

                    if (currentManufacturer == null)
                    {
                        MessageBox.Show("Hãng sản xuất không tồn tại.");
                        return;
                    }

                    var updateManufacturer = new DTO.Manufacturer
                    {
                        id = manufacturerId,
                        ManufacturerName = txtTenSX.Text,
                        createdAt = currentManufacturer.createdAt,
                        updatedAt = DateTime.Now
                    };

                    man.UpdateManufacturer(updateManufacturer);

                    MessageBox.Show("Cập nhật danh mục thành công!");
                    LoadManufacturer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

    }
}
