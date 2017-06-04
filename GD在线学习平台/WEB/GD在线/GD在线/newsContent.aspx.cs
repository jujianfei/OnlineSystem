﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using System.Data;

namespace GD在线学习平台
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string newsid = Request.QueryString["newsid"];
                NewsManager nm = new NewsManager();
                News news = nm.SelectById(newsid);

                //设置资源主题
                lblTitle.Text = news.Title;
                lblContent.Text = news.Content;
                lblCreateTime.Text = news.CreateTime;

                //绑定资源评论
                DataTable dt = new CommentManager().SelectByNewsId(newsid);
                if (dt.Rows.Count == 0)
                {
                    //无资源评论
                    emptydata.Visible = true;
                }
                else
                {
                    //有资源评论
                    emptydata.Visible = false;
                    repComment.DataSource = dt;
                    repComment.DataBind();
                }
                repComment.DataSource = new CommentManager().SelectByNewsId(newsid);
                repComment.DataBind();
            }
        }

        //删除按钮
        protected void lbtnDelComment_Click(object sender, EventArgs e)
        {
            //当前点击的按钮
            LinkButton lb = (LinkButton)sender;
            //获取传过来的commentId
            string comId = lb.CommandArgument;
            //删除该评论
            bool b = new CommentManager().Delete(comId);
            if (b)
            {
                //重新绑定资源评论
                string newsid = Request.QueryString["newsid"];
                DataTable dt = new CommentManager().SelectByNewsId(newsid);
                if (dt.Rows.Count == 0)
                {
                    //无资源评论
                    emptydata.Visible = true;
                    repComment.DataSource = dt;
                    repComment.DataBind();
                }
                else
                {
                    //有资源评论
                    emptydata.Visible = false;
                    repComment.DataSource = dt;
                    repComment.DataBind();
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('删除失败，请联系管理员！');</script>");
            }
        }

        //添加资源评论
        protected void btnSub_Click(object sender, EventArgs e)
        {
            //判断验证码是否输入正确
            string code = txtCode.Text.Trim().ToUpper();
            string rightCode = Session["Code"].ToString();
            if (code != rightCode)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('验证码输入错误！');</script>");//提示框，且背景不变白
                return;
            }
            //判断用户是否登录
            if (Model.GoAnyWhere.uid==null)
            {
                 Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('请登录后方可评论！');</script>");//提示框，且背景不变白
                 return;
            }

            //添加进数据库
            string com_content = txtComment.Text;//获取资源评论
            string newsid = Request.QueryString["newsid"];
            int userId = Model.GoAnyWhere.id;
            
            Comment com = new Comment(com_content, userId, newsid);
            bool b = new CommentManager().Insert(com);
            if (b)
            {
                //清空文本框
                txtComment.Text = "";
                txtCode.Text = "";

                //隐藏“该资源目前暂无评论！”
                emptydata.Visible = false;

                //重新绑定资源类别
                repComment.DataSource = new CommentManager().SelectByNewsId(newsid);
                repComment.DataBind();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('添加失败，请联系管理员！');</script>");
            }

        }

        // 根据session的值显示或者隐藏删除评论的按钮
        protected void repComment_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                // 判断session的值显示或者隐藏删除评论的按钮
                if (Session["admin"] != null && Session["admin"].ToString() == Model.Admin.uid && Session["pwd"].ToString() == Model.Admin.pwd)
                {
                    ((LinkButton)e.Item.FindControl("lbtnDelComment")).Visible = true;
                }
            }
        }
    }
}