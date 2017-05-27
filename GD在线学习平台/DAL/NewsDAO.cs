/*
 *制作人：琚建飞
 *创建时间：2016年9月26日15:36:18
 *说明：资源表操作类
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
    public class NewsDAO
    {
        private SQLHelper sqlhelper;

        #region 构造函数
        public NewsDAO()
        {
            sqlhelper = new SQLHelper();
        }
        #endregion

        #region 选择全部资源
        /// <summary>
        /// 选择全部资源
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            string sql = "select * from news";
            dt = new SQLHelper().ExecuteQuery(sql, CommandType.Text);
            return dt;
        }
        #endregion

        #region 取出最新10条资源
        /// <summary>
        /// 取出最新10条资源（所属分类、资源标题、发布时间）
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNewNews()
        {
            return sqlhelper.ExecuteQuery("news_selectNewNews", CommandType.StoredProcedure);
        }

        #endregion

        #region 取出10条热点资源
        /// <summary>
        /// 取出10条热点资源
        /// </summary>
        /// <returns></returns>
        public DataTable SelectHotNews()
        {
            //TODO:取出10条热点资源
            //DataTable dt = new DataTable();
            //dt= sqlhelper.ExecuteQuery("news_selectHotNews", CommandType.StoredProcedure);
            //return dt;
            return sqlhelper.ExecuteQuery("news_selectHotNews", CommandType.StoredProcedure);
        }
        #endregion

        #region 根据类别ID取出该类别下的所有资源
        /// <summary>
        /// 根据类别ID取出该类别下的所有资源
        /// </summary>
        /// <param name="caid">类别ID</param>
        /// <returns></returns>
        public DataTable SelectByCaId(string caid)
        {
            //TODO:取出10条热点资源
            DataTable dt = new DataTable();
            string cmdText = "news_selectByCaId";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@caid",caid)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        #region 根据资源ID取出该条资源主体内容
        /// <summary>
        /// 根据资源ID取出该条资源主体内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public News SelectById(string id)
        {
            //TODO:取出10条热点资源
            News n = new News();
            DataTable dt = new DataTable();
            string cmdText = "news_selectById";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@id",id)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            n.Id = id;
            n.Title = dt.Rows[0]["title"].ToString();
            n.Content = dt.Rows[0]["content"].ToString();
            n.CreateTime = dt.Rows[0]["createTime"].ToString();
            n.CaId = dt.Rows[0]["caId"].ToString();
            return n;
        }
        #endregion

        #region 根据标题搜索资源
        /// <summary>
        /// 根据标题搜索资源
        /// </summary>
        /// <param name="title">资源标题关键字</param>
        /// <returns></returns>
        public DataTable SelectByTitle(string title)
        {
            //TODO:取出10条热点资源
            DataTable dt = new DataTable();
            string cmdText = "news_selectByTitle";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@title",title)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        #region 根据内容搜索资源
        /// <summary>
        /// 根据内容搜索资源
        /// </summary>
        /// <param name="content">资源内容关键字</param>
        /// <returns></returns>
        public DataTable SelectContent(string content)
        {
            //TODO:根据内容搜索资源
            DataTable dt = new DataTable();
            string cmdText = "news_selectByContent";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@content",content)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        #region 增加资源
        /// <summary>
        /// 增加资源
        /// </summary>
        /// <param name="n">资源实体</param>
        /// <returns></returns>
        public bool Insert(News n)
        {
            //TODO:增加资源
            bool flag = false;
            string cmdText = "news_insert";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@title",n.Title),
                 new SqlParameter("@content",n.Content),
                  new SqlParameter("@caid",n.CaId)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 修改资源
        /// <summary>
        /// 修改资源
        /// </summary>
        /// <param name="n">资源实体类</param>
        /// <returns></returns>
        public bool Update(News n)
        {
            //TODO:修改资源
            bool flag = false;
            string cmdText = "news_update";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@id",n.Id),
                new SqlParameter("@title",n.Title),
                new SqlParameter("@content",n.Content),
                new SqlParameter("@caid",n.CaId)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 删除资源
        /// <summary>
        /// 删除资源（连同其下资源评论一起删除）
        /// </summary>
        /// <param name="id">资源id</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            //TODO:删除资源
            bool flag = false;
            string cmdText = "news_delete";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@id",id)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

    }
}


