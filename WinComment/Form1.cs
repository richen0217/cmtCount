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
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string strUrl = txtUrl.Text.Trim();
            ParaCmt para = GetCommetPara(strUrl);
            string cmtUrl = CreateCmtURL(para);
            string cmtHtml = GetHtmlByGet(cmtUrl);
            string html = OperationHTML(cmtHtml);
            DataTable dt = OperationJson(html);
            GVCmt.DataSource = dt;
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
            return str;
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            txtCmt.SelectAll();
        }


        private DataTable OperationJson(string html)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("time", typeof(string));
            dt.Columns.Add("account", typeof(string));
            JObject jo = (JObject)JsonConvert.DeserializeObject(html);
            JArray ja = JArray.Parse(jo["newPosts"].ToString());
            for (int i = 0; i < ja.Count;i++ )
            {
                JObject job = JObject.Parse(ja[i].ToString());
                JArray jar = JArray.Parse(job["1"].ToString());
                for(int k=0;k<jar.Count;k++)
                {
                    JObject jk = JObject.Parse(jar[k].ToString());
                    DataRow dr = dt.NewRow();
                    dr["time"] = jk["t"].ToString();
                    dr["account"] = jk["n"].ToString();
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
    }
}
