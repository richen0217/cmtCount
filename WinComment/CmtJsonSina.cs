using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinComment
{
    public class CmtJsonSina
    {
        public Result result { get; set; }

        public class Result
        {
            public Status status { get; set; }
            public Count count { get; set; }
            public string language { get; set; }
            public string encoding { get; set; }
            public IList<object> top { get; set; }
            public IList<Cmntlist> cmntlist { get; set; }
            public IList<object> cmntlist_wb_verified { get; set; }
            public IList<object> grouplist { get; set; }
            public IList<HotList> hot_list { get; set; }
        }

        public class HotList
        {
            public string status { get; set; }
            public string usertype { get; set; }
            public string thread { get; set; }
            public string parent { get; set; }
            public string level { get; set; }
            public string ip { get; set; }
            public string area { get; set; }
            public string newsid { get; set; }
            public string mid { get; set; }
            public string against { get; set; }
            public string content { get; set; }
            public string nick { get; set; }
            public string length { get; set; }
            public string rank { get; set; }
            public string time { get; set; }
            public string vote { get; set; }
            public string config { get; set; }
            public string agree { get; set; }
            public string channel { get; set; }
            public string uid { get; set; }
        }

        public class Cmntlist
        {
            public string status { get; set; }
            public string usertype { get; set; }
            public string thread { get; set; }
            public string parent { get; set; }
            public string level { get; set; }
            public string ip { get; set; }
            public string area { get; set; }
            public string newsid { get; set; }
            public string mid { get; set; }
            public string against { get; set; }
            public string content { get; set; }
            public string nick { get; set; }
            public string length { get; set; }
            public string rank { get; set; }
            public string time { get; set; }
            public string vote { get; set; }
            public string config { get; set; }
            public string agree { get; set; }
            public string channel { get; set; }
            public string uid { get; set; }
        }

        public class Status
        {
            public string msg { get; set; }
            public int code { get; set; }
        }

        public class Count
        {
            public int qreply { get; set; }
            public int total { get; set; }
            public int show { get; set; }
        }
    }
}
