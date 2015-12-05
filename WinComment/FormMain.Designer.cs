namespace WinComment
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbCmt = new System.Windows.Forms.RadioButton();
            this.rbHot = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(532, 21);
            this.textBox1.TabIndex = 1;
            // 
            // rbCmt
            // 
            this.rbCmt.AutoSize = true;
            this.rbCmt.Location = new System.Drawing.Point(48, 53);
            this.rbCmt.Name = "rbCmt";
            this.rbCmt.Size = new System.Drawing.Size(59, 16);
            this.rbCmt.TabIndex = 2;
            this.rbCmt.TabStop = true;
            this.rbCmt.Text = "newCmt";
            this.rbCmt.UseVisualStyleBackColor = true;
            // 
            // rbHot
            // 
            this.rbHot.AutoSize = true;
            this.rbHot.Location = new System.Drawing.Point(160, 53);
            this.rbHot.Name = "rbHot";
            this.rbHot.Size = new System.Drawing.Size(41, 16);
            this.rbHot.TabIndex = 3;
            this.rbHot.TabStop = true;
            this.rbHot.Text = "hot";
            this.rbHot.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(251, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 387);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rbHot);
            this.Controls.Add(this.rbCmt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbCmt;
        private System.Windows.Forms.RadioButton rbHot;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}