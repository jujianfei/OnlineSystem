/* 
 *  ���ߣ�ţ��
 *  ����ʱ�䣺2016/9/28 16:15:55
 *  ��˵������������ʵ����
 */ 
    /// <summary>
    /// ��������ʵ����
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

        private string userIp;
        /// <summary>
        /// ������ip
        /// </summary>
        public string UserIp
        {
            get { return userIp; }
            set { userIp = value; }
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
        /// ��������Id
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
