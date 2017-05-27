/* 
 *  作者：琚建飞
 *  创建时间：2016/9/28 17:07:56
 *  类说明：资源实体类
 */ 
    /// <summary>
    /// 资源实体类
    /// </summary>
    public class News
    {
        private string id;
        /// <summary>
        /// 主键，自增
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

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
        /// 资源内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string createTime;
        /// <summary>
        /// 资源发表时间
        /// </summary>
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        private string caId;
        /// <summary>
        /// 资源所属类别id
        /// </summary>
        public string CaId
        {
            get { return caId; }
            set { caId = value; }
        }

        public News() { }

        public News(string title, string content, string caId)
        {
            this.content = content;
            this.title = title;
            this.caId = caId;
        }
        public News(string id,string title, string content, string caId)
        {
            this.id = id;
            this.content = content;
            this.title = title;
            this.caId = caId;
        }
    }
