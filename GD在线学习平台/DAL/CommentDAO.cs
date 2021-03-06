﻿/*
 *制作人：琚建飞
 *创建时间：2016年9月26日15:36:18
 *说明：评论表操作类
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
    public  class CommentDAO
    {
        private SQLHelper sqlhelper;
        public CommentDAO()
        {
            sqlhelper = new SQLHelper();
        }

        #region 根据资源ID取出该资源的所有评论
        /// <summary>
        /// 根据资源ID取出该资源的所有评论
        /// </summary>
        /// <param name="newsId">资源ID</param>
        /// <returns></returns>
        public DataTable SelectByNewsId(string newsId)
        {
            DataTable dt = new DataTable();
            string sql = "select c.id, c.createTime,c.content,u.userName  from comment c join UserManager u on c.userId=u.id where newsId=@newsId order by createTime desc";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@newsId",newsId)
            };
            dt = sqlhelper.ExecuteQuery(sql, paras,CommandType.Text);
            return dt;
        }
        #endregion

        #region 添加评论
        /// <summary>
        /// 添加评论
        /// </summary>
        /// <param name="c">评论实体类</param>
        /// <returns></returns>
        public bool Insert(Comment c)
        {
            bool flag = false;
            string sql = "insert into comment ([content],userId,newsId) values(@content,@userId,@newsId)";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@content",c.Centent),
                new SqlParameter("@userId",c.UserId),
                new SqlParameter("@newsId",c.NewsId)
            };
            int res = sqlhelper.ExecuteNonQuery(sql,paras,CommandType.Text);
            if (res>0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 删除评论
        /// <summary>
        /// 删除评论
        /// </summary>
        /// <param name="id">评论id</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            bool flag = false;
            string sql = "delete comment where id=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@id",id),
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras,CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

    }
}
