using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinComment
{
    public class ParaCmt 
    { 

    }
    public class Para163
    {
        public string boardID { get; set; }
        public string threadID { get; set; }
    }

    public class ParaSina
    {
        public string channel { get; set; }
        public string newsid { get; set; }
    }

    public class ParaSohu
    {
        public string newsid { get; set; }
    }

    public class CmtCount
    {
        public int today { get; set; }
        public int yest { get; set; }
        public int befor { get; set; }
    }
}
