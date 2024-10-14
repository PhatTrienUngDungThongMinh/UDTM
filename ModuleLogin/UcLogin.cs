using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuleLogin
{
    public partial class UcLogin : UserControl
    {
        QL_NguoiDung CauHinh=new QL_NguoiDung();
        string _Conn;
        public string Conn
        {
            get { return _Conn; }
            set { _Conn = value; }
        }
        public UcLogin()
        {
            InitializeComponent();
            this.btnLogin.Click += BtnLogin_Click;
        }

        void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + lblUsername.Text.ToLower());
                this.txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("Không được bỏ trống" + lblPassword.Text.ToLower());
                this.txtPassword.Focus();
                return;
            }
            int kq=CauHinh.Check_Config(_Conn); //hàm Check_Config() thuộc Class QL_NguoiDung
            if (kq == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                ProcessConfig();
            }
        }
        public void ProcessConfig()
        {
             UcCauHinh ucch=new UcCauHinh();
            ucch.Show();
        }
        public void ProcessLogin()
        {
            LoginResult result;
            result = CauHinh.Check_User(txtUsername.Text, txtPassword.Text, Conn); 
            //Check_User viết trong Class QL_NguoiDung
            // Wrong username or pass
            if (result == LoginResult.Invalid)
            {
                MessageBox.Show("Sai " + lblUsername.Text + " Hoặc " +lblPassword.Text);
                return;
            }
            // Account had been disabled
            else if (result == LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            MessageBox.Show("Thanh Cong");

        }
        public enum LoginResult
        {
            /// <summary>
            /// Wrong username or password
            /// </summary>
            Invalid,
            /// <summary>
            /// User had been disabled
            /// </summary>
            Disabled,
            /// <summary>
            /// Loging success
            /// </summary>
            Success
        }
    }
}
