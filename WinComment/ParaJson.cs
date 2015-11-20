using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinComment
{
    class ParaJson
    {
        public IList<NewPost> newPosts { get; set; }
        public int tcount { get; set; }
        public string reqtime { get; set; }
    }

    public class NewPost
    {
        public int d { get; set; }
        public CmtDet cmtDet { get; set; }
    }
    public class CmtDet
    {
        public string f { get; set; }
        public string d { get; set; }
        public string b { get; set; }
        public string a { get; set; }
        public string n { get; set; }
        public string l { get; set; }
        public string tsn { get; set; }
        public string ip { get; set; }
        public string timg { get; set; }
        public string v { get; set; }
        public string u { get; set; }
        public string t { get; set; }
        public string fi { get; set; }
        public string userId { get; set; }
        public string p { get; set; }
        public string tid { get; set; }
        public string uturl { get; set; }
        public string ut { get; set; }
        public string utinfo { get; set; }
    }

    
}
