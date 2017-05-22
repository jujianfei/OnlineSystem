using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace 牛腩新闻发布系统
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string caid = Request.QueryString["caid"];      /*从浏览器地址中获取caid*/
                DataTable dt= new NewsManager().SelectByCaId(caid);

                if (dt.Rows.Count != 0)
                {
                    //设置类别名称
                    lblCaName.Text = dt.Rows[0]["name"].ToString();
                    //return;    当查出 结果为0的时候，return代表直接返回，不执行下面的代码
                }
                
                //if (dt.Rows==0)
                //{
                //    lblCaName.Text = "没有此类新闻偶！";
                //}
                //else {
                //    lblCaName.Text = dt.Rows[0]["name"].ToString();
                //}
                                   
                //绑定新闻列表
                gvNews.DataSource = dt;
                gvNews.DataBind();
            }
        }
        ///   <summary>
        ///   将指定字符串按指定长度进行剪切，
        ///   </summary>
        ///   <param   name= "oldStr "> 需要截断的字符串 </param>
        ///   <param   name= "maxLength "> 字符串的最大长度 </param>
        ///   <param   name= "endWith "> 超过长度的后缀 </param>
        ///   <returns> 如果超过长度，返回截断后的新字符串加上后缀，否则，返回原字符串 </returns>
        public static string StringTruncat(string oldStr, int maxLength, string endWith)
        {
            if (string.IsNullOrEmpty(oldStr))
                //   throw   new   NullReferenceException( "原字符串不能为空 ");
                return oldStr + endWith;
            if (maxLength < 1)
                throw new Exception("返回的字符串长度必须大于[0] ");
            if (oldStr.Length > maxLength)
            {
                string strTmp = oldStr.Substring(0, maxLength);
                if (string.IsNullOrEmpty(endWith))
                    return strTmp;
                else
                    return strTmp + endWith;
            }
            return oldStr;
        }
    }
}