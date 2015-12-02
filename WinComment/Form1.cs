using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WinComment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtUrl.Text = "http://news.163.com/15/1130/00/B9KLSTC800014JB6.html";
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string strUrl = txtUrl.Text.Trim();
            ParaCmt para = GetCommetPara(strUrl);
            string cmtUrl = CreateCmtURL(para);
            string cmtHtml = GetHtmlByGet(cmtUrl);
            string html = OperationHTML(cmtHtml);
            txtCmt.Text = html;
            DataTable dt = OperationJson(html);
            lblTotal.Text = GetTotal(html).ToString();
            GVCmt.DataSource = dt;
            lblGet.Text = dt.Rows.Count.ToString();
            lblTod.Text = GetTodayCmt(dt).ToString();
            lblYes.Text = GetYesterdayCmt(dt).ToString();
            lblBef.Text = GetBeforeCmt(dt).ToString();
            //NewPost post = JsonConvert.DeserializeObject<NewPost>();
        }
        private string GetHtmlByGet(string url)
        {
            string codeType = "utf-8";
            string htmlString = string.Empty;
            HttpWebRequest httpWebRequest = null;
            HttpWebResponse httpWebResponse = null;

            Stream stream = null;
            StreamReader streamReader = null;

            try
            {
                //请求页面
                httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
                //获取服务器的返回信息
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                stream = httpWebResponse.GetResponseStream();

                streamReader = new StreamReader(stream, Encoding.GetEncoding(codeType));
                //读取返回页面
                htmlString = streamReader.ReadToEnd();
                //释放资源返回结果
                streamReader.Close();
                stream.Close();
            }
            //处理异常
            catch (Exception ex)
            {
                htmlString = "";
                MessageBox.Show(ex.Message);
            }
            return htmlString;
        }

        private ParaCmt GetCommetPara(string url)
        {
            string html = GetHtmlByGet(url);
            ParaCmt para = new ParaCmt();
            para.boardID = Regex.Match(html, @"(?<=boardId\s+=\s+\"").*(?=\"")").ToString();
            para.threadID = Regex.Match(html, @"(?<=threadId\s+=\s+\"").*(?=\"")").ToString();
            return para;
        }

        private string CreateCmtURL(ParaCmt para)
        {
            return @"http://comment.news.163.com/cache/newlist/" + para.boardID + "/" + para.threadID + "_1.html";
        }

        private string OperationHTML(string html)
        {
            string str = html.Substring(16, html.Length - 18);//为毛是18不是17 ??
            //string behind = "\"details\"";
            //string front = "\"1\"";
            //string behind = @"""details""";
            //string front = @"""1""";
            //str = str.Replace(front,behind);
            return str;
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            txtCmt.Focus();//必须设置焦点
            txtCmt.SelectAll();
        }


        private DataTable OperationJson(string html)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("time", typeof(DateTime));
            dt.Columns.Add("account", typeof(string));
            JObject jo = (JObject)JsonConvert.DeserializeObject(html);
            JArray ja = JArray.Parse(jo["newPosts"].ToString());
            for (int i = 0; i < ja.Count;i++ )
            {
                JObject job = JObject.Parse(ja[i].ToString());
                //JArray jar = JArray.Parse(job["details"].ToString());

                JObject job2 = JObject.Parse(job["1"].ToString());

                int j = 2;
                while(job[""+j+""]!=null)
                {
                    job2 = JObject.Parse(job[""+j+""].ToString());
                    j++;
                }

                DataRow dr = dt.NewRow();
                dr["account"] = job2["b"].ToString();
                dr["time"] = Convert.ToDateTime(job2["t"]);
                
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private string JudgeTable(DataTable dt)
        {
            string strEsg = string.Empty;

            //string strNew = dt.Rows[0]["time"].ToString();

            //var query=from cmt in dt.AsEnumerable()
            int total = dt.Rows.Count;
            int countTod = GetTodayCmt(dt);
            int countYes = 0;
            int countBef = 0;

            if (total <= 8)
            {
                strEsg = "条数过少，不予判断";
            }
            else
            {
                if (countTod >= total)
                {
                    strEsg = "正常";
                }

                if (countTod < 31)
                {

                }
            }
            return strEsg;
        }

        private int GetTodayCmt(DataTable dt)
        {
            return dt.AsEnumerable().Where(item => item.Field<DateTime>("time") >= DateTime.Now.Date).Count();
        }

        private int GetYesterdayCmt(DataTable dt)
        {
            return dt.AsEnumerable().Where(item => item.Field<DateTime>("time") >= DateTime.Now.AddDays(-1) && item.Field<DateTime>("time") < DateTime.Now.Date).Count();
        }

        private int GetBeforeCmt(DataTable dt)
        {
            return dt.AsEnumerable().Where(item => item.Field<DateTime>("time") >= DateTime.Now.AddDays(-2) && item.Field<DateTime>("time") <= DateTime.Now.AddDays(-1)).Count();
        }
        private int GetTotal(string strHtml)
        {
            Regex regex = new Regex(@"(?<=""tcount"":)\d{1,5}");
            return Convert.ToInt32(regex.Match(strHtml).Value);
        }
    }
}
