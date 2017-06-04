using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
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
            if (Model.GoAnyWhere.uid == null)
            {
                uid = "未登录";
            }
            else
            {
                uid = Model.GoAnyWhere.uid;
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
            Model.GoAnyWhere.uid = null;
            return "成功！";
        }
    }
}