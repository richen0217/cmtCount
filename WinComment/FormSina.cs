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
    public partial class FormSina : Form
    {
        public FormSina()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            string html = GetJson.GetHtmlFromGet(url, "utf-8");
            ParaSina sina = GetJson.GetSinaPara(url);
            string cmtUrl = GetJson.CreateSinaCmtsUrl(sina);
            string json = GetJson.GetSinaJson(cmtUrl);
            //DataTable dt = GetJson.OperaSinaJson(json);
            txtJson.Text = json;
            string cmtUrl2 = GetJson.CreateSinaCmtsUrl2(sina);
            string json2 = GetJson.GetSinaJson(cmtUrl);
            //DataTable dt = GetJson.OperaSinaJson(json);
            txtJson2.Text = json2;
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            txtJson.Focus();
            txtJson.SelectAll();
        }
    }
}
