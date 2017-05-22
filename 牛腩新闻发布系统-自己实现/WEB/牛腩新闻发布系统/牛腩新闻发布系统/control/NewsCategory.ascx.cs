/*
    *创建人：琚建飞
    *创建时间：2016年10月4日10:12:50
    *版权所有：信息技术提高班
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace 牛腩新闻发布系统.control
{
    public partial class NewsCategory : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (true)
            {
                //绑定新闻分类
                repCategory.DataSource = new CategoryManager().SelectAll();
                repCategory.DataBind();
            }    
        }
    }
}