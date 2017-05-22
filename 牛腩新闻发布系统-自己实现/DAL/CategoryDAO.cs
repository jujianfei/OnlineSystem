/*
 *制作人：琚建飞
 *制作时间：2016年9月27日03:35:43
 *说明：新闻类别表操作类
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    /// <summary>
    /// 新闻类别表操作类
    /// </summary>
    public class CategoryDAO
    {
        private SQLHelper sqlhelper = null;
        public CategoryDAO() //构造函数
        {
            sqlhelper = new SQLHelper();
        }
         //取出当前所有新闻分类
        public DataTable selectAll()
        {
            DataTable dt = new DataTable();
            string sql = "select * from category";
            dt = sqlhelper.ExecuteQuery(sql,CommandType.Text);
            return dt;
        }
	     /// <summary>
        /// 增加类别
	     /// </summary>
	     /// <param name="caName">类别名称</param>
	     /// <returns></returns>
        public bool Insert(string caName)
        {
            bool flag = false;
            string sql = "insert into category(name) values(@caName)";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@caName",caName)
            };
            int res=sqlhelper.ExecuteNonQuery(sql,paras,CommandType.Text);
            if (res>0)
            {
                flag = true;
            }
            return flag;
        }

	     /// <summary>
        /// 修改类别
	     /// </summary>
	     /// <param name="id">类别ID</param>
	     /// <param name="caName">类别名称</param>
	     /// <returns></returns>
        public bool Update(Category ca)
        {
            bool flag = false;
            string sql = "update category set [name]=@caName where id=@id";
            SqlParameter[] paras = new SqlParameter[]{
                 new SqlParameter("@id",ca.Id),
                new SqlParameter("@caName",ca.Name)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras,CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

	     //删除类别（连同其下的新闻及新闻评论一起删除）
        public bool Delete(string id)
        {
            bool flag = false;
            string sql = "delete from category where id=@id";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@id",id)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
         /// <summary>
        /// 判断类别名称是否已存在
         /// </summary>
         /// <param name="caName">类别名称</param>
         /// <returns></returns>
        public bool IsExists(string caName)
        {
            bool flag = false;
            string sql = "select * from category where [name] ='"+caName+"'";
            DataTable dt = sqlhelper.ExecuteQuery(sql,CommandType.Text);
            if (dt.Rows.Count>0)
            {
                flag = true;
            }
            return flag;
        }
    }
}
