namespace WinComment
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtCmt = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.SelectAll = new System.Windows.Forms.Button();
            this.GVCmt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GVCmt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "url:";
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(79, 30);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(767, 21);
            this.txtUrl.TabIndex = 1;
            // 
            // txtCmt
            // 
            this.txtCmt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCmt.Location = new System.Drawing.Point(79, 74);
            this.txtCmt.Multiline = true;
            this.txtCmt.Name = "txtCmt";
            this.txtCmt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCmt.Size = new System.Drawing.Size(767, 165);
            this.txtCmt.TabIndex = 2;
            // 
            // btnGet
            // 
            this.btnGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGet.Location = new System.Drawing.Point(888, 74);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "获取";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // SelectAll
            // 
            this.SelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectAll.Location = new System.Drawing.Point(888, 121);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(75, 23);
            this.SelectAll.TabIndex = 4;
            this.SelectAll.Text = "全选";
            this.SelectAll.UseVisualStyleBackColor = true;
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // GVCmt
            // 
            this.GVCmt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCmt.Location = new System.Drawing.Point(79, 273);
            this.GVCmt.Name = "GVCmt";
            this.GVCmt.RowTemplate.Height = 23;
            this.GVCmt.Size = new System.Drawing.Size(767, 150);
            this.GVCmt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 407);
            this.Controls.Add(this.GVCmt);
            this.Controls.Add(this.SelectAll);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtCmt);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GVCmt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtCmt;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button SelectAll;
        private System.Windows.Forms.DataGridView GVCmt;
    }
}

