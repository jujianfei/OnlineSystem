using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GD在线.admin
{
    public partial class addNotice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //判断标题是否为空
            if (txtTitle.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('标题内容为空，请输入标题内容！');</script>");
            }
            //判断内容是否为空
            else if (ftbContent.Text=="")
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('公告内容为空，请输入公告内容！');</script>");
            }
            else
            {
                string title = txtTitle.Text.Trim();
                string content = ftbContent.Text.Trim();
                int aid = Convert.ToInt32(Session["admin"].ToString());
                Model.Notice n = new Model.Notice(title,content,aid);

                BLL.NoticeManager nm = new BLL.NoticeManager();
                bool b = nm.Insert(n);
                if (b)
                {
                     Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('公告添加成功！');</script>");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('公告添加失败，请联系管理员！');</script>");
                }
                //清空标题和内容
                txtTitle.Text = "";
                ftbContent.Text = "";
            }
        }
    }
}