/*
 * ==================
 * 创建人：琚建飞
 * 创建时间：2017/6/5 17:58:19
 * 说明：
 * ==================
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class NoticeDAO
    {
        private SQLHelper sqlhelper;

        public NoticeDAO()
        {
            sqlhelper = new SQLHelper();
        }
        /// <summary>
        /// 添加公告
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool Insert(Model.Notice n)
        {
            bool flag = false;
            string cmdText = "addNotice";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@title",n.Title),
                 new SqlParameter("@content",n.Content),
                  new SqlParameter("@aid",n.Aid)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        /// <summary>
        /// 选择一条最新公告
        /// </summary>
        /// <returns></returns>
        public Model.Notice SelectNotice()
        {
            Model.Notice n = new Model.Notice();
            DataTable dt = new DataTable();
            string cmdText = "SelectNewNotice";
            dt = sqlhelper.ExecuteQuery(cmdText,CommandType.StoredProcedure);
            n.Title = dt.Rows[0]["title"].ToString();
            n.Content= dt.Rows[0]["content"].ToString();
            n.CreateTime = dt.Rows[0]["createTime"].ToString();
            return n;
        }
    }
}
