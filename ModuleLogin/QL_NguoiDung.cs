using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ModuleLogin.UcLogin;

namespace ModuleLogin
{
    public class QL_NguoiDung
    {
        public QL_NguoiDung() { 

        }

        public int Check_Config(string pConn)
        {
            if (pConn == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tạiSqlConnection _Sqlconn = new
                SqlConnection _Sqlconn = new SqlConnection(pConn);
     
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }
        public LoginResult Check_User(string pUser, string pPass,string pConn)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from Users where Email = '" + pUser + "' and Password = '" + pPass + "'", pConn);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return LoginResult.Invalid;// User không tồn tại
            else if (dt.Rows[0][7] == null || dt.Rows[0][7].ToString() =="False")
            {
                return LoginResult.Disabled;// Không hoạt động
            }
            return LoginResult.Success;// Đăng nhập thành công
        }

    }
}
