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
       
        public frmHome()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            //var products = db.Category.ToList(); // Fetch all products from the database

            //// Assign the products list to the DataGridView's DataSource
            //dataGridView1.DataSource = products;
            //dataGridView1 = new DataGridView();
            //dataGridView1.DataSource = 
        }
    }
}
