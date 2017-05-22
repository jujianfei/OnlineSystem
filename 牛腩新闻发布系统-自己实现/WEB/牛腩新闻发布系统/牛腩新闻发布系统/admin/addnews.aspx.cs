using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 牛腩新闻发布系统.admin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 判断session里面是否存在管理员
            if (Session["admin"] != null && Session["admin"].ToString() == "jujianfei")
            {
                // 已登陆
                if (!Page.IsPostBack)
                {
                    // 绑定新闻分类
                    DataTable dt = new CategoryManager().SelectAll();
                    ddlCategory.DataSource = dt;
                    ddlCategory.DataTextField = "name";
                    ddlCategory.DataValueField = "id";
                    ddlCategory.DataBind();
                }
            }
            else
            {
                // 未登陆
                Response.Redirect("login.aspx");
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string content = ftbContent.Text.Trim();
            string caid = ddlCategory.SelectedValue;

            News n = new News(title, content, caid);

            bool b = new NewsManager().Insert(n);

            if (b)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('新闻添加成功！');</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('新闻添加失败，请联系管理员！');</script>");
            }

            // 清空标题和内容
            txtTitle.Text = "";
            ftbContent.Text = "";
        }
    }
}