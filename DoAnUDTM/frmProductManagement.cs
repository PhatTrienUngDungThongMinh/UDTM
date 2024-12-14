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
    public partial class frmProductManagement : Form
    {
        public frmProductManagement()
        {
            InitializeComponent();
        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProducts()
        {
            ProductBLL productBLL = new ProductBLL();
            DsSanPham.DataSource = productBLL.GetAllProducts();
            LoadComboBoxData();
        }
        private void LoadComboBoxData()
        {
          
            CategoryBLL categoryBLL = new CategoryBLL();
            WarrantyPolicyBLL warrantyBLL = new WarrantyPolicyBLL();
            ManufacturerBLL manufacturerBLL = new ManufacturerBLL();
            CountryOfOriginBLL countryBLL = new CountryOfOriginBLL();

           
            cbbDanhMuc.DataSource = categoryBLL.GetAllCategories();
            cbbDanhMuc.DisplayMember = "CategoryName"; 
            cbbDanhMuc.ValueMember = "id"; 

            cbbBaoHanh.DataSource = warrantyBLL.GetAllWarrantyPolicies();
            cbbBaoHanh.DisplayMember = "WarrantyProvider"; 
            cbbBaoHanh.ValueMember = "id"; 

            cbbHangSX.DataSource = manufacturerBLL.GetAllManufacturers();
            cbbHangSX.DisplayMember = "ManufacturerName"; 
            cbbHangSX.ValueMember = "id"; 

            cbbNuocXX.DataSource = countryBLL.GetAllCountries();
            cbbNuocXX.DisplayMember = "CountryName"; 
            cbbNuocXX.ValueMember = "id";
        }

        private void DsSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = DsSanPham.Rows[e.RowIndex];

          
                txtMaSP.Text = row.Cells["id"].Value.ToString();
                txtTenSP.Text = row.Cells["ProductName"].Value.ToString();
                txtGiaGoc.Text = row.Cells["ListedPrice"].Value.ToString();
                txtGiaGiam.Text = row.Cells["PromotionalPrice"].Value.ToString();
                txtTonKho.Text = row.Cells["Stock"].Value.ToString();
                txtMoTa.Text = row.Cells["Description"].Value.ToString();

    
                cbbDanhMuc.SelectedValue = row.Cells["CategoryID"].Value; 
                cbbBaoHanh.SelectedValue = row.Cells["WarrantyPolicyID"].Value;
                cbbHangSX.SelectedValue = row.Cells["ManufacturerID"].Value;
                cbbNuocXX.SelectedValue = row.Cells["CountryID"].Value;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaGoc.Clear();
            txtGiaGiam.Clear();
            txtTonKho.Clear();
            txtMoTa.Clear();

            cbbDanhMuc.SelectedIndex = 0;
            cbbBaoHanh.SelectedIndex = 0;
            cbbHangSX.SelectedIndex = 0;
            cbbNuocXX.SelectedIndex = 0;

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaSP.Text))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int productId = int.Parse(txtMaSP.Text);
                ProductBLL productBLL = new ProductBLL();

                productBLL.DeleteProduct(productId);
                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu sản phẩm này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ProductBLL productBLL = new ProductBLL();
                    Product newProduct = new Product
                    {
                        ProductName = txtTenSP.Text.Trim(),
                        ListedPrice = decimal.Parse(txtGiaGoc.Text),
                        PromotionalPrice = decimal.Parse(txtGiaGiam.Text),
                        Stock = int.Parse(txtTonKho.Text),
                        Sold = 0,
                        Status = "Active",
                        Description = txtMoTa.Text.Trim(),
                        CategoryID = (int)cbbDanhMuc.SelectedValue,
                        WarrantyPolicyID = (int)cbbBaoHanh.SelectedValue,
                        ManufacturerID = (int)cbbHangSX.SelectedValue,
                        CountryID = (int)cbbNuocXX.SelectedValue,
                        createdAt = DateTime.Now,
                        updatedAt = DateTime.Now,
                    };

                    productBLL.AddProduct(newProduct);  
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
