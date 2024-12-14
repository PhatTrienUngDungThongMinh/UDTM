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
    public partial class frmProductCategorization : Form
    {
        CategoryBLL category = new CategoryBLL();
        public frmProductCategorization()
        {
            InitializeComponent();
        }

        private void frmProductCategorization_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            DsDanhMuc.DataSource = category.GetAllCategories();
            DsDanhMuc.CellClick += DsDanhMuc_CellClick;
        }


        private void DsDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = DsDanhMuc.Rows[e.RowIndex];

                txtMaDM.Text = row.Cells["id"].Value.ToString();
                txtTenDM.Text = row.Cells["CategoryName"].Value.ToString();
                txtCreate.Text = row.Cells["createdAt"].Value.ToString();
                txtupdate.Text = row.Cells["updatedAt"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn thêm danh mục này không?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(txtTenDM.Text))
                    {
                        MessageBox.Show("Tên danh mục không được để trống.");
                        return;
                    }

                    var newCategory = new DTO.Category
                    {
                        CategoryName = txtTenDM.Text,
                        createdAt = DateTime.Now,
                        updatedAt = DateTime.Now
                    };

                    category.AddCategory(newCategory);
                    MessageBox.Show("Thêm danh mục thành công!");
                    LoadCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }


        // Xóa Category
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaDM.Text))
                {
                    MessageBox.Show("Chưa chọn danh mục để xóa.");
                    return;
                }

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này không?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int categoryId = Convert.ToInt32(txtMaDM.Text);
                    try
                    {
                        category.DeleteCategory(categoryId);
                        MessageBox.Show("Xóa danh mục thành công!");
                        LoadCategories();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("FK"))
                        {
                            MessageBox.Show("Vui lòng xử lý các khóa ngoại trước khi xóa danh mục này.");
                        }
                        else
                        {
                            MessageBox.Show($"Lỗi: {ex.Message}");
                        }
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
                if (string.IsNullOrWhiteSpace(txtMaDM.Text) || string.IsNullOrWhiteSpace(txtTenDM.Text))
                {
                    MessageBox.Show("Vui lòng chọn danh mục và nhập tên danh mục.");
                    return;
                }

                int categoryId = Convert.ToInt32(txtMaDM.Text);

                var result = MessageBox.Show("Bạn có chắc chắn muốn sửa danh mục này không?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var currentCategory = category.GetAllCategories().FirstOrDefault(c => c.id == categoryId);

                    if (currentCategory == null)
                    {
                        MessageBox.Show("Danh mục không tồn tại.");
                        return;
                    }

                    var updatedCategory = new DTO.Category
                    {
                        id = categoryId,
                        CategoryName = txtTenDM.Text,
                        createdAt = currentCategory.createdAt,
                        updatedAt = DateTime.Now
                    };

                    category.UpdateCategory(updatedCategory);

                    MessageBox.Show("Cập nhật danh mục thành công!");
                    LoadCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
    }
}
