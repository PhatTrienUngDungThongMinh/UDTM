using System.Drawing;
using System.Windows.Forms;

namespace DoAnUDTM
{
    partial class frmDiscountAndPromotionManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DsKhuyenMai = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtMaKM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labal22 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtToida = new System.Windows.Forms.TextBox();
            this.txtGiamgia = new System.Windows.Forms.TextBox();
            this.txtNgayKT = new System.Windows.Forms.TextBox();
            this.dateTimeNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dateKT = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DsKhuyenMai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(10, 537);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 59);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác Vụ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(603, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 34);
            this.button4.TabIndex = 14;
            this.button4.Text = "Hủy";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(424, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 34);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(245, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 34);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(66, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 34);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DsKhuyenMai);
            this.groupBox3.Location = new System.Drawing.Point(5, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 360);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Khuyễn Mãi";
            // 
            // DsKhuyenMai
            // 
            this.DsKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DsKhuyenMai.Location = new System.Drawing.Point(5, 11);
            this.DsKhuyenMai.Name = "DsKhuyenMai";
            this.DsKhuyenMai.Size = new System.Drawing.Size(793, 343);
            this.DsKhuyenMai.TabIndex = 0;
            // 
            // txtMaKM
            // 
            this.txtMaKM.Enabled = false;
            this.txtMaKM.Location = new System.Drawing.Point(97, 23);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Size = new System.Drawing.Size(144, 20);
            this.txtMaKM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã khuyến mãi";
            // 
            // txtTenKM
            // 
            this.txtTenKM.Location = new System.Drawing.Point(97, 68);
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.Size = new System.Drawing.Size(144, 20);
            this.txtTenKM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên khuyến mãi";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(97, 109);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(144, 20);
            this.txtGiaTri.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá Tri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày bắt đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ngày kết thúc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(536, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã code";
            // 
            // labal22
            // 
            this.labal22.AutoSize = true;
            this.labal22.Location = new System.Drawing.Point(536, 71);
            this.labal22.Name = "labal22";
            this.labal22.Size = new System.Drawing.Size(74, 13);
            this.labal22.TabIndex = 16;
            this.labal22.Text = "Giá trị tối thiểu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(536, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Giảm giá tối đa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateKT);
            this.groupBox1.Controls.Add(this.dateTimeNgayBD);
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.txtToida);
            this.groupBox1.Controls.Add(this.txtGiamgia);
            this.groupBox1.Controls.Add(this.txtNgayKT);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.labal22);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGiaTri);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenKM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaKM);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 161);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khuyến Mãi";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(351, 109);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(144, 20);
            this.txtSoluong.TabIndex = 24;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(625, 109);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(144, 20);
            this.txtCode.TabIndex = 23;
            // 
            // txtToida
            // 
            this.txtToida.Location = new System.Drawing.Point(625, 68);
            this.txtToida.Name = "txtToida";
            this.txtToida.Size = new System.Drawing.Size(144, 20);
            this.txtToida.TabIndex = 22;
            // 
            // txtGiamgia
            // 
            this.txtGiamgia.Location = new System.Drawing.Point(625, 23);
            this.txtGiamgia.Name = "txtGiamgia";
            this.txtGiamgia.Size = new System.Drawing.Size(144, 20);
            this.txtGiamgia.TabIndex = 21;
            // 
            // txtNgayKT
            // 
            this.txtNgayKT.Location = new System.Drawing.Point(351, 64);
            this.txtNgayKT.Name = "txtNgayKT";
            this.txtNgayKT.Size = new System.Drawing.Size(144, 20);
            this.txtNgayKT.TabIndex = 19;
            // 
            // dateTimeNgayBD
            // 
            this.dateTimeNgayBD.Location = new System.Drawing.Point(351, 23);
            this.dateTimeNgayBD.Name = "dateTimeNgayBD";
            this.dateTimeNgayBD.Size = new System.Drawing.Size(144, 20);
            this.dateTimeNgayBD.TabIndex = 25;
            // 
            // dateKT
            // 
            this.dateKT.Location = new System.Drawing.Point(351, 65);
            this.dateKT.Name = "dateKT";
            this.dateKT.Size = new System.Drawing.Size(144, 20);
            this.dateKT.TabIndex = 26;
            // 
            // frmDiscountAndPromotionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 623);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmDiscountAndPromotionManagement";
            this.Text = "frmDiscountAndPromotionManagement";
            this.Load += new System.EventHandler(this.frmDiscountAndPromotionManagement_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DsKhuyenMai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private Button btnThem;
        private GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView DsKhuyenMai;
        private TextBox txtMaKM;
        private Label label1;
        private TextBox txtTenKM;
        private Label label2;
        private TextBox txtGiaTri;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labal22;
        private Label label10;
        private GroupBox groupBox1;
        private TextBox txtSoluong;
        private TextBox txtCode;
        private TextBox txtToida;
        private TextBox txtGiamgia;
        private TextBox txtNgayKT;
        private Button button4;
        private Button btnSua;
        private Button btnXoa;
        private DateTimePicker dateTimeNgayBD;
        private DateTimePicker dateKT;
    }
}