/*
 *制作人：琚建飞
 *创建时间：2016年9月26日15:36:18
 *说明：评论表操作类
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class CommentManager
    {
        private CommentDAO cdao = null;
        public CommentManager()
        {
            cdao = new CommentDAO();
        }

        #region 根据资源ID取出该资源的所有评论
        /// <summary>
        /// 根据资源ID取出该资源的所有评论
        /// </summary>
        /// <param name="newsId">资源ID</param>
        /// <returns></returns>
        public DataTable SelectByNewsId(string newsId)
        {
            return cdao.SelectByNewsId(newsId);
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
            return cdao.Insert(c);
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
            return cdao.Delete(id);
        }
        #endregion

    }
}
