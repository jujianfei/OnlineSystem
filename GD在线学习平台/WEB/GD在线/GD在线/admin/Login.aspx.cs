using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace GD在线学习平台
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //登录按钮
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //判断验证码是否输入正确
            string code = txtCode.Text.Trim().ToUpper();
            string rightCode = Session["Code"].ToString();
            if (code != rightCode)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('验证码输入错误！');</script>");//提示框，且背景不变白
                return;
            }

            //获取输入的数据
            string name = txtUserName.Text.Trim();
            string pwd = txtPassword.Text.Trim();

            bool b = AdminManager.Login(name,pwd);
            if (b)
            {
                //登录成功，跳转到categorymanager.aspx页面
                Session["admin"] = name;
                Session["pwd"] = pwd;
                Model.Admin.uid = name;
                Model.Admin.pwd = pwd;
                Response.Redirect("categorymanager.aspx");
            }
            else
            { 
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('登录失败，用户名或者密码错误！');</script>");
            }
        }     
    }
}