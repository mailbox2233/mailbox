namespace mail
{
    partial class Main
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
            this.bnt_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textUserpasswd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_insert_email = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnt_send
            // 
            this.bnt_send.Location = new System.Drawing.Point(116, 291);
            this.bnt_send.Name = "bnt_send";
            this.bnt_send.Size = new System.Drawing.Size(75, 23);
            this.bnt_send.TabIndex = 0;
            this.bnt_send.Text = "发送";
            this.bnt_send.UseVisualStyleBackColor = true;
            this.bnt_send.Click += new System.EventHandler(this.bnt_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "账号:";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(53, 9);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(115, 21);
            this.textUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // textUserpasswd
            // 
            this.textUserpasswd.Location = new System.Drawing.Point(238, 9);
            this.textUserpasswd.Name = "textUserpasswd";
            this.textUserpasswd.PasswordChar = '*';
            this.textUserpasswd.Size = new System.Drawing.Size(100, 21);
            this.textUserpasswd.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(371, 9);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.textUserpasswd);
            this.panel2.Controls.Add(this.textUsername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 40);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_insert_email);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 67);
            this.panel1.TabIndex = 8;
            // 
            // btn_insert_email
            // 
            this.btn_insert_email.Location = new System.Drawing.Point(32, 25);
            this.btn_insert_email.Name = "btn_insert_email";
            this.btn_insert_email.Size = new System.Drawing.Size(75, 23);
            this.btn_insert_email.TabIndex = 0;
            this.btn_insert_email.Text = "导入邮箱";
            this.btn_insert_email.UseVisualStyleBackColor = true;
            this.btn_insert_email.Click += new System.EventHandler(this.btn_insert_email_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(606, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bnt_send);
            this.Name = "Main";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnt_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUserpasswd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_insert_email;
        private System.Windows.Forms.Button button1;
    }
}

