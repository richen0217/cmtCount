using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinComment
{
    public class CmtJsonQQ
    {
        public int errCode { get; set; }
        public Data data { get; set; }
        public Info info { get; set; }
    }
    public class Info
    {
        public int time { get; set; }
    }
    public class Data
    {
        public int targetid { get; set; }
        public int display { get; set; }
        public int total { get; set; }
        public int reqnum { get; set; }
        public int retnum { get; set; }
        public string maxid { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public bool hasnext { get; set; }
        public IList<Commentid> commentid { get; set; }
        public Targetinfo targetinfo { get; set; }
    }
    public class Extend
    {
        public int at { get; set; }
        public int ut { get; set; }
    }

    public class Liveaddr
    {
        public string country { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string area { get; set; }
    }

    public class Wbuserinfo
    {
        public string name { get; set; }
        public string nick { get; set; }
        public string url { get; set; }
        public int vip { get; set; }
        public int ep { get; set; }
        public string brief { get; set; }
        public string identification { get; set; }
        public string intro { get; set; }
        public Liveaddr liveaddr { get; set; }
        public int gender { get; set; }
        public int level { get; set; }
        public string classify { get; set; }
    }

    public class Userinfo
    {
        public string userid { get; set; }
        public string uidex { get; set; }
        public string nick { get; set; }
        public string head { get; set; }
        public int gender { get; set; }
        public string viptype { get; set; }
        public int mediaid { get; set; }
        public string region { get; set; }
        public int thirdlogin { get; set; }
        public int hwvip { get; set; }
        public int hwlevel { get; set; }
        public int hwannual { get; set; }
        public string identity { get; set; }
        public Wbuserinfo wbuserinfo { get; set; }
        public string remark { get; set; }
        public int fnd { get; set; }
    }

    public class Commentid
    {
        public string id { get; set; }
        public string rootid { get; set; }
        public int targetid { get; set; }
        public string parent { get; set; }
        public string timeDifference { get; set; }
        public int time { get; set; }
        public string content { get; set; }
        public string title { get; set; }
        public string up { get; set; }
        public string rep { get; set; }
        public string type { get; set; }
        public string hotscale { get; set; }
        public string checktype { get; set; }
        public string checkstatus { get; set; }
        public string isdeleted { get; set; }
        public string tagself { get; set; }
        public string taghost { get; set; }
        public string source { get; set; }
        public string location { get; set; }
        public string address { get; set; }
        public string rank { get; set; }
        public string custom { get; set; }
        public Extend extend { get; set; }
        public string orireplynum { get; set; }
        public int richtype { get; set; }
        public string userid { get; set; }
        public int poke { get; set; }

        //public string abstract { get; set; }//
        public string thirdid { get; set; }
        public string replyuser { get; set; }
        public int replyuserid { get; set; }
        public int replyhwvip { get; set; }
        public int replyhwlevel { get; set; }
        public int replyhwannual { get; set; }
        public Userinfo userinfo { get; set; }
    }

    public class Targetinfo
    {
        public int orgcommentnum { get; set; }
        public string commentnum { get; set; }
        public string checkstatus { get; set; }
        public string checktype { get; set; }
        public string city { get; set; }
        public string voteid { get; set; }
    }
}
