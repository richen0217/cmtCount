using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinComment
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            string html = GetJson.GetHtmlFromGet(url, "gb2312");
            //ParaSina sina = GetJson.GetSinaPara(url);
            //string cmtUrl = GetJson.CreateUrlSinaCmt(sina);
            //string json = GetJson.GetSinaJson(cmtUrl);
            //DataTable dt = GetJson.OperaSinaJson(json);
            txtJson.Text = html;
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            txtJson.Focus();
            txtJson.SelectAll();
        }
    }
}
