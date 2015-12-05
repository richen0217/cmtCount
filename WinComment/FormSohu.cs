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
    public partial class FormSohu : Form
    {
        public FormSohu()
        {
            InitializeComponent();
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            txtCmt.Focus();
            txtCmt.SelectAll();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            ParaSohu sohu = GetJson.GetParaSohu(url);
            string html = GetJson.GetSohuJson(sohu);
            string json = GetJson.DealSohuHtml(html);
            DataTable dt = GetJson.OperaSohuJson(json);
            txtNew.Text = GetJson.CreateSohuJsonUrl(sohu);
            GVSohu.DataSource = dt;
            txtCmt.Text = json;
        }
    }
}
