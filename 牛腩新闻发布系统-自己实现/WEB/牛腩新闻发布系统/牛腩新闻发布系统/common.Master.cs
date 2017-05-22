using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 牛腩新闻发布系统
{
    public partial class common : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //搜索按钮
        protected void btn_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text.Trim();

            string action = radTitle.Checked ? "bytitle" : "bycontent";//三元运算符
            //跳转页面到searchRes.aspx
            Response.Redirect("~/searchRes.aspx?key=" + Server.UrlEncode(key) + "&action=" + action); //   在asp.net里面，"~/"它的意思是跳转到根目录下的页面
        }
    }
}