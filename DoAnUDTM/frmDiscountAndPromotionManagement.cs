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
        }
    }
}
