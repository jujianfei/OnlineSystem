/* 
 *  作者：牛腩
 *  创建时间：2016/9/28 16:15:55
 *  类说明：新闻评论实体类
 */ 
    /// <summary>
    /// 新闻评论实体类
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

        private string userIp;
        /// <summary>
        /// 评论人ip
        /// </summary>
        public string UserIp
        {
            get { return userIp; }
            set { userIp = value; }
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
        /// 所属新闻Id
        /// </summary>
        public string NewsId
        {
            get { return newsId; }
            set { newsId = value; }
        }

        public Comment()
        { }

        public Comment(string content,string userIp,string newsId)
        {
            this.centent = content;
            this.userIp = userIp;
            this.newsId = newsId;
        }
    }
