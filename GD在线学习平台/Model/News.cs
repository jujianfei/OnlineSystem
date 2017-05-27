/* 
 *  ���ߣ�袽���
 *  ����ʱ�䣺2016/9/28 17:07:56
 *  ��˵������Դʵ����
 */ 
    /// <summary>
    /// ��Դʵ����
    /// </summary>
    public class News
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

        private string title;
        /// <summary>
        /// ����
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string content;
        /// <summary>
        /// ��Դ����
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string createTime;
        /// <summary>
        /// ��Դ����ʱ��
        /// </summary>
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        private string caId;
        /// <summary>
        /// ��Դ�������id
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
