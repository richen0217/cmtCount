using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinComment
{
    public class Comment
    {
        public string comment_id { get; set; }
        public string article_id { get; set; }
        public string special_id { get; set; }
        public string uname { get; set; }
        public string user_id { get; set; }
        public string uuid { get; set; }
        public string client_ip { get; set; }
        public string ip_from { get; set; }
        public string create_time { get; set; }
        public string comment_contents { get; set; }
        public string quote_id { get; set; }
        public string main_id { get; set; }
        public string from { get; set; }
        public string comment_temid { get; set; }
        public string is_valid { get; set; }
        public string integral { get; set; }
        public string extension1 { get; set; }
        public string extension2 { get; set; }
        public string extension3 { get; set; }
        public string ext2 { get; set; }
        public string ext3 { get; set; }
        public string channel_id { get; set; }
        public string useragent { get; set; }
        public string sisp_channel { get; set; }
        public IList<object> parent { get; set; }
        public string faceurl { get; set; }
        public string user_url { get; set; }
        public int uptimes { get; set; }
        public string doc_url { get; set; }
        public string doc_name { get; set; }
        public string comment_date { get; set; }
    }

    public class CmtJsoniFeng
    {
        public int count { get; set; }
        public int join_count { get; set; }
        public IList<Comment> comments { get; set; }
        public int allow_comment { get; set; }
        public IList<object> nopass { get; set; }
    }
    

}
