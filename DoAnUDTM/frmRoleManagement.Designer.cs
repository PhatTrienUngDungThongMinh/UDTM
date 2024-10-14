using System.Drawing;
using System.Windows.Forms;

namespace DoAnUDTM
{
    partial class frmRoleManagement
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
            groupBoxInfo = new GroupBox();
            txtDescription = new TextBox();
            txtRoleName = new TextBox();
            lblDescription = new Label();
            lblRoleName = new Label();
            groupBoxPermissions = new GroupBox();
            chkAllPermissions = new CheckBox();
            chkListPermissions = new CheckedListBox();
            btnSave = new Button();
            btnBack = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            comboBox2 = new ComboBox();
            label1 = new Label();
            groupBoxInfo.SuspendLayout();
            groupBoxPermissions.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(txtDescription);
            groupBoxInfo.Controls.Add(txtRoleName);
            groupBoxInfo.Controls.Add(lblDescription);
            groupBoxInfo.Controls.Add(lblRoleName);
            groupBoxInfo.Location = new Point(20, 21);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(417, 100);
            groupBoxInfo.TabIndex = 0;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Thông tin Nhóm quyền mới";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(100, 60);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(300, 23);
            txtDescription.TabIndex = 3;
            // 
            // txtRoleName
            // 
            txtRoleName.Location = new Point(100, 30);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(300, 23);
            txtRoleName.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 60);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(41, 15);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Mô tả:";
            // 
            // lblRoleName
            // 
            lblRoleName.AutoSize = true;
            lblRoleName.Location = new Point(20, 30);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(80, 15);
            lblRoleName.TabIndex = 0;
            lblRoleName.Text = "Nhóm quyền:";
            // 
            // groupBoxPermissions
            // 
            groupBoxPermissions.Controls.Add(chkAllPermissions);
            groupBoxPermissions.Controls.Add(chkListPermissions);
            groupBoxPermissions.Location = new Point(363, 150);
            groupBoxPermissions.Name = "groupBoxPermissions";
            groupBoxPermissions.Size = new Size(417, 300);
            groupBoxPermissions.TabIndex = 1;
            groupBoxPermissions.TabStop = false;
            groupBoxPermissions.Text = "Chọn quyền";
            // 
            // chkAllPermissions
            // 
            chkAllPermissions.AutoSize = true;
            chkAllPermissions.Location = new Point(20, 30);
            chkAllPermissions.Name = "chkAllPermissions";
            chkAllPermissions.Size = new Size(118, 19);
            chkAllPermissions.TabIndex = 1;
            chkAllPermissions.Text = "Chọn toàn quyền";
            chkAllPermissions.UseVisualStyleBackColor = true;
            // 
            // chkListPermissions
            // 
            chkListPermissions.FormattingEnabled = true;
            chkListPermissions.Items.AddRange(new object[] { "Khách hàng", "Mua hàng", "Bán hàng", "Báo cáo", "Marketing", "Kho hàng", "Danh mục", "Quỹ", "Quản trị user", "Survey", "Dự án", "Catalog" });
            chkListPermissions.Location = new Point(20, 60);
            chkListPermissions.Name = "chkListPermissions";
            chkListPermissions.Size = new Size(379, 220);
            chkListPermissions.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(705, 33);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Lưu ";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(519, 33);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Hủy";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(455, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 58);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm quyền";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(284, 23);
            comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(20, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 300);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các quyền đã thêm";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(284, 220);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(141, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Sửa Quyền";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(222, 27);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Xóa quyền";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(54, 28);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(81, 23);
            comboBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 30);
            label1.Name = "label1";
            label1.Size = new Size(35, 17);
            label1.TabIndex = 4;
            label1.Text = "Lọc :";
            // 
            // frmRoleManagement
            // 
            ClientSize = new Size(800, 451);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxPermissions);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(groupBoxInfo);
            Name = "frmRoleManagement";
            Text = "Thêm mới nhóm quyền";
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            groupBoxPermissions.ResumeLayout(false);
            groupBoxPermissions.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.GroupBox groupBoxPermissions;
        private System.Windows.Forms.CheckBox chkAllPermissions;
        private System.Windows.Forms.CheckedListBox chkListPermissions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox2;
        private Button button2;
        private Button button1;
    }
}