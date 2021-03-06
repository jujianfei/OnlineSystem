﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Configuration;

namespace GD在线
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod(EnableSession = true)]
        public static string hite(string a, string b)
        {

            SqlConnection conn = new SqlConnection("server=.;database=GDOnline;uid=sa;pwd=jujianfei");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select id, userName,userPassword from UserManager where userName='" + a + "' And userPassword='" + b + "'";
            cmd.Connection = conn;
            conn.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    dr.Read();//不管dr取到多少条数据，只取出第一行
                    //将用户登录id写到全局变量id中
                    Model.GoAnyWhere.id = dr.GetInt32(0); 
                    //将用户名和密码写到Session中
                    HttpContext.Current.Session["username"] = a;
                    HttpContext.Current.Session["password"] = b;
                    return "登录成功！";
                }
                else
                {
                    return "登录失败！";
                }
            }
        }

        [WebMethod]
        public static string hite2(string a, string b)
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "insert into UserManager(userName,userPassword) values(@name,@pwd)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlParameter[] spa = new SqlParameter[] { 
                 new SqlParameter("@name",a),
                 new SqlParameter("@pwd",b)
            };
            cmd.Parameters.AddRange(spa);
            conn.Open();
            int dr = cmd.ExecuteNonQuery();
            if (dr > 0)
            {
                conn.Close();
                return "注册成功！";
            }
            else
            {
                conn.Close();
                return "注册失败，请联系管理员！";
            }
        }
    }
}