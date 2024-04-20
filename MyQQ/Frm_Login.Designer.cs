namespace MyQQ
{
    partial class Frm_Login
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.TextBox();
            this.userpassword = new System.Windows.Forms.TextBox();
            this.PboxMin = new System.Windows.Forms.PictureBox();
            this.pboxClose = new System.Windows.Forms.PictureBox();
            this.pboxLogin = new System.Windows.Forms.PictureBox();
            this.cboxRemember = new System.Windows.Forms.CheckBox();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.linkFindPWD = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PboxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(165, 249);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(315, 28);
            this.username.TabIndex = 0;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            // 
            // userpassword
            // 
            this.userpassword.Location = new System.Drawing.Point(165, 308);
            this.userpassword.Name = "userpassword";
            this.userpassword.PasswordChar = '*';
            this.userpassword.Size = new System.Drawing.Size(315, 28);
            this.userpassword.TabIndex = 1;
            this.userpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userpassword_KeyPress);
            // 
            // PboxMin
            // 
            this.PboxMin.BackColor = System.Drawing.Color.Transparent;
            this.PboxMin.Location = new System.Drawing.Point(540, 13);
            this.PboxMin.Name = "PboxMin";
            this.PboxMin.Size = new System.Drawing.Size(29, 24);
            this.PboxMin.TabIndex = 2;
            this.PboxMin.TabStop = false;
            this.PboxMin.Click += new System.EventHandler(this.PboxMin_Click);
            // 
            // pboxClose
            // 
            this.pboxClose.BackColor = System.Drawing.Color.Transparent;
            this.pboxClose.Location = new System.Drawing.Point(577, 13);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(29, 24);
            this.pboxClose.TabIndex = 3;
            this.pboxClose.TabStop = false;
            this.pboxClose.Click += new System.EventHandler(this.pboxClose_Click);
            // 
            // pboxLogin
            // 
            this.pboxLogin.BackColor = System.Drawing.Color.Transparent;
            this.pboxLogin.Location = new System.Drawing.Point(136, 397);
            this.pboxLogin.Name = "pboxLogin";
            this.pboxLogin.Size = new System.Drawing.Size(344, 54);
            this.pboxLogin.TabIndex = 4;
            this.pboxLogin.TabStop = false;
            this.pboxLogin.Click += new System.EventHandler(this.pboxLogin_Click);
            // 
            // cboxRemember
            // 
            this.cboxRemember.AutoSize = true;
            this.cboxRemember.Location = new System.Drawing.Point(136, 356);
            this.cboxRemember.Name = "cboxRemember";
            this.cboxRemember.Size = new System.Drawing.Size(106, 22);
            this.cboxRemember.TabIndex = 6;
            this.cboxRemember.Text = "记住密码";
            this.cboxRemember.UseVisualStyleBackColor = true;
            this.cboxRemember.CheckedChanged += new System.EventHandler(this.cboxRemember_CheckedChanged);
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkRegister.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkRegister.Location = new System.Drawing.Point(287, 360);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(80, 18);
            this.linkRegister.TabIndex = 7;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "注册账号";
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked_1);
            // 
            // linkFindPWD
            // 
            this.linkFindPWD.AutoSize = true;
            this.linkFindPWD.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkFindPWD.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkFindPWD.Location = new System.Drawing.Point(400, 360);
            this.linkFindPWD.Name = "linkFindPWD";
            this.linkFindPWD.Size = new System.Drawing.Size(80, 18);
            this.linkFindPWD.TabIndex = 8;
            this.linkFindPWD.TabStop = true;
            this.linkFindPWD.Text = "忘记密码";
            this.linkFindPWD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFindPWD_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(268, 356);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 26);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 440);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 25);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::MyQQ.Properties.Resources.登录界面;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(618, 477);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkFindPWD);
            this.Controls.Add(this.cboxRemember);
            this.Controls.Add(this.pboxLogin);
            this.Controls.Add(this.pboxClose);
            this.Controls.Add(this.PboxMin);
            this.Controls.Add(this.userpassword);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyQQ登录";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PboxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox userpassword;
        private System.Windows.Forms.PictureBox PboxMin;
        private System.Windows.Forms.PictureBox pboxClose;
        private System.Windows.Forms.PictureBox pboxLogin;
        private System.Windows.Forms.CheckBox cboxRemember;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.LinkLabel linkFindPWD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

