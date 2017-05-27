using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace GD在线
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string hite(string a, string b)
        {
            SqlConnection conn = new SqlConnection("server=.;database=NewsSystem;uid=sa;pwd=jujianfei");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select userName,userPassword from UserManager where userName='" + a + "' And userPassword='" + b + "'";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                return "登录成功！";
            }
            else
            {
                return "登录失败！";
            }
        }
    }
}