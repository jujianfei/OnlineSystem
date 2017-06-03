/* 
 *  作者：琚建飞
 *  创建时间：2016/9/28 16:15:55
 *  类说明：资源评论实体类
 */ 
    /// <summary>
    /// 资源评论实体类
    /// </summary>
    public class Comment
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

        private string centent;
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Centent
        {
            get { return centent; }
            set { centent = value; }
        }

        private int userId;
        /// <summary>
        /// 评论人id
        /// </summary>
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        private string creatTime;
        /// <summary>
        /// 评论发表时间
        /// </summary>
        public string CreatTime
        {
            get { return creatTime; }
            set { creatTime = value; }
        }

        private string newsId;
        /// <summary>
        /// 所属资源Id
        /// </summary>
        public string NewsId
        {
            get { return newsId; }
            set { newsId = value; }
        }

        public Comment()
        { }

        public Comment(string content,int userId,string newsId)
        {
            this.centent = content;
            this.userId = userId;
            this.newsId = newsId;
        }
    }
