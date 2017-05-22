using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using System.Data;
using System.Data.SqlClient;
using BLL;


namespace 牛腩新闻发布系统.admin
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 判断session里面是否存在管理员
            if (Session["admin"] != null && Session["admin"].ToString() == "jujianfei")
            {
                // 已登陆
                if (!Page.IsPostBack)
                {
                    BindNews();
                }
            }
            else
            {
                // 未登陆
                Response.Redirect("login.aspx");
            }
        }

       // 删除按钮
    protected void lbtnDel_Click(object sender, EventArgs s)
    {
        string id = ((LinkButton)sender).CommandArgument;
       bool b =  new NewsManager().Delete(id);       
        if (b)
        {
            BindNews();
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('未知原因导致删除失败！');</script>");     
        }
    }

        #region 绑定新闻列表
        private void BindNews()
        {
            repNews.DataSource = new NewsManager().SelectAll();
            repNews.DataBind();
        }
        #endregion
    }
}