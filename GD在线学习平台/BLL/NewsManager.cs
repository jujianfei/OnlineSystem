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
using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class NewsManager
    {
        private NewsDAO ndao = null;
        public NewsManager()
        {
            ndao = new NewsDAO();
        }

        #region 选择全部资源
        /// <summary>
        /// 选择全部资源
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAll()
        {
            return ndao.SelectAll();
        }
        #endregion

        #region 取出最新10条资源
        /// <summary>
        /// 取出最新10条资源（所属分类、资源标题、发布时间）
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNewNews()
        {
            return ndao.SelectNewNews();
        }
        #endregion

        #region 取出10条热点资源
        /// <summary>
        /// 取出10条热点资源
        /// </summary>
        /// <returns></returns>
        public DataTable SelectHotNews()
        {
            return ndao.SelectHotNews();
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
            return ndao.SelectByCaId(caid);
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
            return ndao.SelectById(id);
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
            return ndao.SelectByTitle(title);
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
            return ndao.SelectContent(content);
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
            return ndao.Insert(n);
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
            return ndao.Update(n);
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
            return ndao.Delete(id);
        }
        #endregion
    }
}
