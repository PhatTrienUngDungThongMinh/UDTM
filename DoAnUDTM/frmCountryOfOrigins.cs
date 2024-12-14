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
    public partial class frmCountryOfOrigins : Form
    {
        CountryOfOriginBLL countryOfOriginBLL = new CountryOfOriginBLL();

        public frmCountryOfOrigins()
        {
            InitializeComponent();
        }

        private void frmCountryOfOrigins_Load(object sender, EventArgs e)
        {
            LoadCountries();
        }

        private void LoadCountries()
        {
            dataGridView1.DataSource= countryOfOriginBLL.GetAllCountries();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaXX.Text = row.Cells["id"].Value.ToString();
                txtTenXX.Text = row.Cells["CountryName"].Value.ToString();
                txtNgayTao.Text = row.Cells["createdAt"].Value.ToString();
                txtNgayUpdate.Text = row.Cells["updatedAt"].Value.ToString();
            }
        }

        private void btnnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn thêm xuất xứ này không?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(txtTenXX.Text))
                    {
                        MessageBox.Show("Tên nước xuất xứ không được để trống.");
                        return;
                    }

                    var newCountry = new DTO.CountryOfOrigin
                    {
                        CountryName = txtTenXX.Text,
                        createdAt = DateTime.Now,
                        updatedAt = DateTime.Now
                    };

                    countryOfOriginBLL.AddCountry(newCountry);
                    MessageBox.Show("Thêm nước xuất xứ thành công!");
                    LoadCountries();
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
                if (string.IsNullOrWhiteSpace(txtMaXX.Text))
                {
                    MessageBox.Show("Chưa chọn nước xuất xứ để xóa.");
                    return;
                }

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nước này không?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int countryId = Convert.ToInt32(txtMaXX.Text);
                    try
                    {
                        countryOfOriginBLL.DeleteCountry(countryId);
                        MessageBox.Show("Xóa danh mục thành công!");
                        LoadCountries();
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
                if (string.IsNullOrWhiteSpace(txtMaXX.Text) || string.IsNullOrWhiteSpace(txtTenXX.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhập tên nước xuất xứ.");
                    return;
                }

                int countryId = Convert.ToInt32(txtMaXX.Text);

                var result = MessageBox.Show("Bạn có chắc chắn muốn sửa nước xuất xứ này không?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var currentCountry = countryOfOriginBLL.GetAllCountries().FirstOrDefault(c => c.id == countryId);

                    if (currentCountry == null)
                    {
                        MessageBox.Show("Nước xuất xứ không tồn tại.");
                        return;
                    }

                    var updatedCountry = new DTO.CountryOfOrigin
                    {
                        id = countryId,
                        CountryName = txtTenXX.Text,
                        createdAt = currentCountry.createdAt,
                        updatedAt = DateTime.Now
                    };

                    countryOfOriginBLL.UpdateCountry(updatedCountry);

                    MessageBox.Show("Cập nhật danh mục thành công!");
                    LoadCountries();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
