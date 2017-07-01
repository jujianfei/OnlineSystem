using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GD在线学习平台
{
    public partial class common : System.Web.UI.MasterPage
    {
        protected string uid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["username"] != null)
            {
                uid = HttpContext.Current.Session["username"].ToString();
            }
            else if (Session["admin"]!=null)
            {
                uid = Session["admin"].ToString();
            }
            else
            {
                uid = "未登录";
            }
        }

        //搜索按钮
        protected void btn_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text.Trim();

            string action = radTitle.Checked ? "bytitle" : "bycontent";//三元运算符
            //跳转页面到searchRes.aspx
            Response.Redirect("~/searchRes.aspx?key=" + Server.UrlEncode(key) + "&action=" + action); //   在asp.net里面，"~/"它的意思是跳转到根目录下的页面
        }

        public static string modify()
        {
            HttpContext.Current.Session["username"] = null;
            return "退出成功！";
        }
        [WebMethod]
        public static string ShowValue()
        {
            HttpContext.Current.Session["username"] = null;
            return "退出成功！";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Session["username"] = null;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            HttpContext.Current.Session["username"] = null;
            string url = HttpContext.Current.Request.Url.ToString();//获取当前页的url
            string url2 = HttpContext.Current.Request.UrlReferrer.ToString();//获取上一页的url
            if (url == "http://localhost:10698/admin/categorymanager.aspx")
            {
                Response.Redirect("error.html");
            }
            else
            {
                Response.Redirect("homePage.aspx", false); 
            }
        }
    }
}