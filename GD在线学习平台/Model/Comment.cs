/* 
 *  ���ߣ�袽���
 *  ����ʱ�䣺2016/9/28 16:15:55
 *  ��˵������Դ����ʵ����
 */ 
    /// <summary>
    /// ��Դ����ʵ����
    /// </summary>
    public class Comment
    {
        private string id;
        /// <summary>
        /// ����������
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string centent;
        /// <summary>
        /// ��������
        /// </summary>
        public string Centent
        {
            get { return centent; }
            set { centent = value; }
        }

        private int userId;
        /// <summary>
        /// ������id
        /// </summary>
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        private string creatTime;
        /// <summary>
        /// ���۷���ʱ��
        /// </summary>
        public string CreatTime
        {
            get { return creatTime; }
            set { creatTime = value; }
        }

        private string newsId;
        /// <summary>
        /// ������ԴId
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
