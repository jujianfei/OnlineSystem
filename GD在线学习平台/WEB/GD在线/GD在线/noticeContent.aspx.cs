using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GD在线
{
    public partial class NoticeList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BLL.NoticeManager m = new BLL.NoticeManager();
                Model.Notice n = m.SelectNotice();
                lblTitle.Text = n.Title;
                lblContent.Text = n.Content;
                lblCreateTime.Text = n.CreateTime;
            }
        }
    }
}