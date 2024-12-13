namespace DoAnUDTM
{
    partial class frmAddUserToPermissionGroup
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lstPermissionGroups = new System.Windows.Forms.ListBox();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGroups = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPermissionGroups
            // 
            this.lstPermissionGroups.Location = new System.Drawing.Point(395, 200);
            this.lstPermissionGroups.Name = "lstPermissionGroups";
            this.lstPermissionGroups.Size = new System.Drawing.Size(350, 147);
            this.lstPermissionGroups.TabIndex = 1;
            this.lstPermissionGroups.SelectedIndexChanged += new System.EventHandler(this.lstPermissionGroups_SelectedIndexChanged);
            // 
            // dgvMembers
            // 
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvMembers.Location = new System.Drawing.Point(12, 50);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.Size = new System.Drawing.Size(345, 297);
            this.dgvMembers.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID tài khoản";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Username ";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên tài khoản";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Họ và tên";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lblGroups
            // 
            this.lblGroups.AutoSize = true;
            this.lblGroups.Location = new System.Drawing.Point(392, 184);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(129, 13);
            this.lblGroups.TabIndex = 0;
            this.lblGroups.Text = "Danh Sách Nhóm Quyền:";
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Location = new System.Drawing.Point(12, 20);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(123, 13);
            this.lblMembers.TabIndex = 2;
            this.lblMembers.Text = "Thành Viên trong Nhóm:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(117, 19);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 51);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(17, 19);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Tên tài khoản :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(84, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Quyền đã chọn:";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(17, 79);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(84, 23);
            this.btnAddMember.TabIndex = 11;
            this.btnAddMember.Text = "Thêm";
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(130, 79);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(84, 23);
            this.btnDeleteMember.TabIndex = 12;
            this.btnDeleteMember.Text = "Xóa";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(233, 79);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDeleteMember);
            this.groupBox1.Controls.Add(this.btnAddMember);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Location = new System.Drawing.Point(395, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 120);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thành viên";
            // 
            // frmAddUserToPermissionGroup
            // 
            this.ClientSize = new System.Drawing.Size(765, 369);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblGroups);
            this.Controls.Add(this.lstPermissionGroups);
            this.Controls.Add(this.lblMembers);
            this.Controls.Add(this.dgvMembers);
            this.Name = "frmAddUserToPermissionGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhóm Quyền và Thành Viên";
            this.Load += new System.EventHandler(this.frmAddUserToPermissionGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        

        private System.Windows.Forms.ListBox lstPermissionGroups;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}