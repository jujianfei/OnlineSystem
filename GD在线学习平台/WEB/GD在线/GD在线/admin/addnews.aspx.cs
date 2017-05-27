using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GD在线学习平台.admin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 判断session里面是否存在管理员
            if (Session["admin"] != null && Session["admin"].ToString() == Model.Admin.uid && Session["pwd"].ToString() == Model.Admin.pwd)
            {
                // 已登陆
                if (!Page.IsPostBack)
                {
                    // 绑定资源分类
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
        //添加按钮
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //判断标题是否为空
            if (txtTitle.Text=="")
            {
                 Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('标题内容为空，请输入标题内容！');</script>");
            }
            else
            {
                //判断内容是否为空
                string title = txtTitle.Text.Trim();
                string content = ftbContent.Text.Trim();
                string caid = ddlCategory.SelectedValue;

                News n = new News(title, content, caid);

                bool b = new NewsManager().Insert(n);

                if (b)
                {
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('资源添加成功！');</script>");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('资源添加失败，请联系管理员！');</script>");
                }

                // 清空标题和内容
                txtTitle.Text = "";
                ftbContent.Text = "";
            }
        }
    }
}