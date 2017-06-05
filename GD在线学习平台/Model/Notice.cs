/*
 * ==================
 * 创建人：琚建飞
 * 创建时间：2017/6/5 19:53:02
 * 说明：公告实体类
 * ==================
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Notice
    {
        private string title;
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string content;
        /// <summary>
        /// 内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string createTime;
        /// <summary>
        /// 内容
        /// </summary>
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        private int aid;
        /// <summary>
        /// 管理员id
        /// </summary>
        public int Aid
        {
            get { return aid; }
            set { aid = value; }
        }
        public Notice()
        { }
        public Notice(string title, string content, int aid)
        {
            this.content = content;
            this.title = title;
            this.aid = aid;
        }
        public Notice(string title, string content, string createTime)
        {
            this.content = content;
            this.title = title;
            this.createTime = createTime;
        }
    }
}
