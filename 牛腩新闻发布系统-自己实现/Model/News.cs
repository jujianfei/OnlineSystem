/* 
 *  ���ߣ�ţ��
 *  ����ʱ�䣺2016/9/28 17:07:56
 *  ��˵��������ʵ����
 */ 
    /// <summary>
    /// ����ʵ����
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
        /// ��������
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string createTime;
        /// <summary>
        /// ���ŷ���ʱ��
        /// </summary>
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        private string caId;
        /// <summary>
        /// �����������id
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
    }
