using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnUDTM
{
    public partial class frmDiscountAndPromotionManagement : Form
    {
        PromotionBLL promotion = new PromotionBLL();

        public frmDiscountAndPromotionManagement()
        {
            InitializeComponent();
        }

        private void frmDiscountAndPromotionManagement_Load(object sender, EventArgs e)
        {
            DsKhuyenMai.DataSource = promotion.GetAllPromotions();

            DsKhuyenMai.CellClick += DsKhuyenMai_CellClick;
            dateTimeNgayBD.Format = DateTimePickerFormat.Custom;
            dateTimeNgayBD.CustomFormat = "dd/MM/yyyy"; 

            dateKT.Format = DateTimePickerFormat.Custom;
            dateKT.CustomFormat = "dd/MM/yyyy"; 
        }

        private void DsKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DsKhuyenMai.Rows[e.RowIndex];
               
                txtMaKM.Text = row.Cells["id"].Value != DBNull.Value ? row.Cells["id"].Value.ToString() : string.Empty;
                txtTenKM.Text = row.Cells["PromotionName"].Value != DBNull.Value ? row.Cells["PromotionName"].Value.ToString() : string.Empty;
                txtGiaTri.Text = row.Cells["DiscountValue"].Value != DBNull.Value ? row.Cells["DiscountValue"].Value.ToString() : string.Empty;

                if (row.Cells["StartDate"].Value != DBNull.Value && row.Cells["StartDate"].Value != null)
                {
                    dateTimeNgayBD.Text = row.Cells["StartDate"].Value.ToString();
                }
                else
                {
                    dateTimeNgayBD.Text = string.Empty;
                }
                if (row.Cells["EndDate"].Value != DBNull.Value && row.Cells["EndDate"].Value != null)
                {
                    dateKT.Text = row.Cells["EndDate"].Value.ToString();
                }
                else
                {
                    dateKT.Text = string.Empty;
                }

                txtSoluong.Text = row.Cells["Quantity"].Value != DBNull.Value ? row.Cells["Quantity"].Value.ToString() : string.Empty;
                txtGiamgia.Text = row.Cells["MinValue"].Value != DBNull.Value ? row.Cells["MinValue"].Value.ToString() : string.Empty;
                txtToida.Text = row.Cells["MaxDiscount"].Value != DBNull.Value ? row.Cells["MaxDiscount"].Value.ToString() : string.Empty;
                txtCode.Text = row.Cells["Code"].Value != DBNull.Value ? row.Cells["Code"].Value.ToString() : string.Empty;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenKM.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaTri.Text) ||
                    string.IsNullOrWhiteSpace(txtSoluong.Text) ||
                    string.IsNullOrWhiteSpace(txtGiamgia.Text) ||
                    string.IsNullOrWhiteSpace(txtToida.Text) ||
                    string.IsNullOrWhiteSpace(txtCode.Text) ||
                    dateTimeNgayBD.Value == null ||
                    dateKT.Value == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khuyến mãi.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                DialogResult confirm = MessageBox.Show(
                    "Bạn có chắc chắn muốn thêm khuyến mãi này không?",
                    "Xác nhận thêm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    string promotionCode = txtCode.Text;
                    var existingPromotion = promotion.GetAllPromotions().FirstOrDefault(p => p.Code == promotionCode);

                    if (existingPromotion != null)
                    {
                        MessageBox.Show("Mã khuyến mãi đã tồn tại. Vui lòng nhập mã khác.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var newPromotion = new Promotion
                    {
                        PromotionName = txtTenKM.Text,
                        DiscountValue = decimal.Parse(txtGiaTri.Text),
                        StartDate = dateTimeNgayBD.Value,
                        EndDate = dateKT.Value,
                        Quantity = int.Parse(txtSoluong.Text),
                        MinValue = decimal.Parse(txtGiamgia.Text),
                        MaxDiscount = decimal.Parse(txtToida.Text),
                        Code = txtCode.Text
                    };
                    promotion.AddPromotion(newPromotion);
                    MessageBox.Show("Thêm khuyến mãi thành công!", "Thông báo");

                    DsKhuyenMai.DataSource = promotion.GetAllPromotions();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi");
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show(
                    "Bạn có chắc chắn muốn cập nhật khuyến mãi này không?",
                    "Xác nhận sửa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

             
                if (confirm == DialogResult.Yes)
                {
                    string promotionCode = txtCode.Text;
                    var existingPromotion = promotion.GetAllPromotions()
                        .FirstOrDefault(p => p.Code == promotionCode && p.id != int.Parse(txtMaKM.Text));

                    if (existingPromotion != null)
                    {
                        MessageBox.Show("Mã khuyến mãi đã tồn tại. Vui lòng nhập mã khác.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var updatedPromotion = new Promotion
                    {
                        id = int.Parse(txtMaKM.Text),
                        PromotionName = txtTenKM.Text,
                        DiscountValue = decimal.Parse(txtGiaTri.Text),
                        StartDate = dateTimeNgayBD.Value,
                        EndDate = dateKT.Value,
                        Quantity = int.Parse(txtSoluong.Text),
                        MinValue = decimal.Parse(txtGiamgia.Text),
                        MaxDiscount = decimal.Parse(txtToida.Text),
                        Code = txtCode.Text
                    };

                    promotion.UpdatePromotion(updatedPromotion);
                    MessageBox.Show("Cập nhật khuyến mãi thành công!", "Thông báo");

                    DsKhuyenMai.DataSource = promotion.GetAllPromotions();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi");
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int promotionId = int.Parse(txtMaKM.Text);
                DialogResult confirm = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa khuyến mãi này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    promotion.DeletePromotion(promotionId);
                    MessageBox.Show("Xóa khuyến mãi thành công!", "Thông báo");

                    DsKhuyenMai.DataSource = promotion.GetAllPromotions();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi");
            }
        }

    }
}
