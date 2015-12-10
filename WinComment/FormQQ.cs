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
    public partial class FormQQ : Form
    {
        public FormQQ()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            txtCount.Focus();
            txtCount.SelectAll();
        }

        private void btnHot_Click(object sender, EventArgs e)
        {
            txtHot.Focus();
            txtHot.SelectAll();
        }

        private void btnCmt_Click(object sender, EventArgs e)
        {
            txtCmt.Focus();
            txtCmt.SelectAll();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            string html = GetJson.GetHtmlFromGet(url, "gb2312");
            string paraQQ = GetJson.GetParaQQ(html);
            string count = GetJson.CreateQQCountUrl(paraQQ);
            string hot = GetJson.CreateQQHotUrl(paraQQ);
            string cmt = GetJson.CreateQQCmtUrl(paraQQ);
            txtCount.Text = GetJson.DealQQCountHtml(GetJson.GetHtmlFromGet(count, "gb2312"));
            txtHot.Text = GetJson.DealQQHotHtml(GetJson.GetHtmlFromGet(hot, "gb2312"));
            txtCmt.Text = GetJson.DealQQCmtHtml(GetJson.GetHtmlFromGet(cmt, "gb2312"));
        }
    }
}
