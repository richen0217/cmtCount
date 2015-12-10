namespace WinComment
{
    partial class FormQQ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtHot = new System.Windows.Forms.TextBox();
            this.txtCmt = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnHot = new System.Windows.Forms.Button();
            this.btnCmt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(13, 24);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 12);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "URL:";
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(48, 21);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(594, 21);
            this.txtUrl.TabIndex = 1;
            // 
            // txtCount
            // 
            this.txtCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCount.Location = new System.Drawing.Point(48, 63);
            this.txtCount.Multiline = true;
            this.txtCount.Name = "txtCount";
            this.txtCount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCount.Size = new System.Drawing.Size(594, 48);
            this.txtCount.TabIndex = 2;
            // 
            // txtHot
            // 
            this.txtHot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHot.Location = new System.Drawing.Point(48, 129);
            this.txtHot.Multiline = true;
            this.txtHot.Name = "txtHot";
            this.txtHot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHot.Size = new System.Drawing.Size(594, 103);
            this.txtHot.TabIndex = 3;
            // 
            // txtCmt
            // 
            this.txtCmt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCmt.Location = new System.Drawing.Point(48, 255);
            this.txtCmt.Multiline = true;
            this.txtCmt.Name = "txtCmt";
            this.txtCmt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCmt.Size = new System.Drawing.Size(594, 164);
            this.txtCmt.TabIndex = 4;
            // 
            // btnGet
            // 
            this.btnGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGet.Location = new System.Drawing.Point(698, 21);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 5;
            this.btnGet.Text = "获取";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnCount
            // 
            this.btnCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCount.Location = new System.Drawing.Point(698, 77);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 6;
            this.btnCount.Text = "Count全选";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnHot
            // 
            this.btnHot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHot.Location = new System.Drawing.Point(698, 175);
            this.btnHot.Name = "btnHot";
            this.btnHot.Size = new System.Drawing.Size(75, 23);
            this.btnHot.TabIndex = 7;
            this.btnHot.Text = "Hot全选";
            this.btnHot.UseVisualStyleBackColor = true;
            this.btnHot.Click += new System.EventHandler(this.btnHot_Click);
            // 
            // btnCmt
            // 
            this.btnCmt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCmt.Location = new System.Drawing.Point(698, 310);
            this.btnCmt.Name = "btnCmt";
            this.btnCmt.Size = new System.Drawing.Size(75, 23);
            this.btnCmt.TabIndex = 8;
            this.btnCmt.Text = "Cmt全选";
            this.btnCmt.UseVisualStyleBackColor = true;
            this.btnCmt.Click += new System.EventHandler(this.btnCmt_Click);
            // 
            // FormQQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 431);
            this.Controls.Add(this.btnCmt);
            this.Controls.Add(this.btnHot);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtCmt);
            this.Controls.Add(this.txtHot);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Name = "FormQQ";
            this.Text = "FormQQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtHot;
        private System.Windows.Forms.TextBox txtCmt;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnHot;
        private System.Windows.Forms.Button btnCmt;
    }
}