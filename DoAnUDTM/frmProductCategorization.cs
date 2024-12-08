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
        CategoryBLL category  = new CategoryBLL();
        public frmProductCategorization()
        {
            InitializeComponent();
        }

        private void frmProductCategorization_Load(object sender, EventArgs e)
        {
            DsDanhMuc.DataSource = category.GetAllCategories();
        }
    }
}
