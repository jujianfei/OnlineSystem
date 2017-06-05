/*
 * ==================
 * 创建人：琚建飞
 * 创建时间：2017/6/5 20:03:33
 * 说明：
 * ==================
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class NoticeManager
    {
        private DAL.NoticeDAO ndao = null;
        public NoticeManager()
        {
            ndao = new DAL.NoticeDAO();
        }
        public bool Insert(Model.Notice n)
        {
            return ndao.Insert(n);
        }
        public Model.Notice SelectNotice()
        {
            return ndao.SelectNotice();
        }

    }
}
