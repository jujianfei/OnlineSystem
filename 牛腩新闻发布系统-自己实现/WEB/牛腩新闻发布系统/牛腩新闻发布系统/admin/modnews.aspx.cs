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
    public partial class modnews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 判断session里面是否存在管理员
            if (Session["admin"] != null && Session["admin"].ToString() == Model.Admin.uid && Session["pwd"].ToString() == Model.Admin.pwd)
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

                    //显示新闻标题和内容
                    string newsid=Request.QueryString["newsid"];
                    News n = new NewsManager().SelectById(newsid);
                    txtTitle.Text = n.Title;
                    ftbContent.Text = n.Content;
                    ddlCategory.SelectedValue = n.CaId;
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
            string newsid = Request.QueryString["newsid"];
            string title = txtTitle.Text.Trim();
            string content = ftbContent.Text.Trim();
            string caid = ddlCategory.SelectedValue;

            News n = new News(newsid,title, content, caid);

            bool b = new NewsManager().Update(n);

            if (b)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('资料修改成功！');</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('资料修改失败，请联系管理员！');</script>");
            }

            // 清空标题和内容
            txtTitle.Text = "";
            ftbContent.Text = "";
        }
    }
}