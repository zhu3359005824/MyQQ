namespace MyQQ
{
    partial class Frm_Register
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxJob = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnWoman = new System.Windows.Forms.RadioButton();
            this.rbtnMan = new System.Windows.Forms.RadioButton();
            this.tbPwdAgain = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MyQQ.Properties.Resources._1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-42, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 629);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxJob);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rbtnWoman);
            this.groupBox1.Controls.Add(this.rbtnMan);
            this.groupBox1.Controls.Add(this.tbPwdAgain);
            this.groupBox1.Controls.Add(this.tbPwd);
            this.groupBox1.Controls.Add(this.tbAge);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(363, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 455);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "注册基本信息";
            // 
            // cboxJob
            // 
            this.cboxJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxJob.FormattingEnabled = true;
            this.cboxJob.Items.AddRange(new object[] {
            "学生",
            "教师",
            "其他"});
            this.cboxJob.Location = new System.Drawing.Point(134, 213);
            this.cboxJob.Name = "cboxJob";
            this.cboxJob.Size = new System.Drawing.Size(179, 26);
            this.cboxJob.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "工作";
            // 
            // rbtnWoman
            // 
            this.rbtnWoman.AutoSize = true;
            this.rbtnWoman.Location = new System.Drawing.Point(233, 163);
            this.rbtnWoman.Name = "rbtnWoman";
            this.rbtnWoman.Size = new System.Drawing.Size(51, 22);
            this.rbtnWoman.TabIndex = 11;
            this.rbtnWoman.TabStop = true;
            this.rbtnWoman.Text = "女";
            this.rbtnWoman.UseVisualStyleBackColor = true;
            // 
            // rbtnMan
            // 
            this.rbtnMan.AutoSize = true;
            this.rbtnMan.Location = new System.Drawing.Point(134, 163);
            this.rbtnMan.Name = "rbtnMan";
            this.rbtnMan.Size = new System.Drawing.Size(51, 22);
            this.rbtnMan.TabIndex = 10;
            this.rbtnMan.TabStop = true;
            this.rbtnMan.Text = "男";
            this.rbtnMan.UseVisualStyleBackColor = true;
            // 
            // tbPwdAgain
            // 
            this.tbPwdAgain.Location = new System.Drawing.Point(134, 343);
            this.tbPwdAgain.Name = "tbPwdAgain";
            this.tbPwdAgain.PasswordChar = '*';
            this.tbPwdAgain.Size = new System.Drawing.Size(179, 28);
            this.tbPwdAgain.TabIndex = 9;
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(134, 282);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.PasswordChar = '*';
            this.tbPwd.Size = new System.Drawing.Size(179, 28);
            this.tbPwd.TabIndex = 8;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(134, 91);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(179, 28);
            this.tbAge.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(134, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(179, 28);
            this.tbName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "重复密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "年龄";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "昵称";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(406, 529);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(79, 34);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(624, 529);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 34);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 625);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "申请账号";
            this.Load += new System.EventHandler(this.Frm_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RadioButton rbtnWoman;
        private System.Windows.Forms.RadioButton rbtnMan;
        private System.Windows.Forms.TextBox tbPwdAgain;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.ComboBox cboxJob;
        private System.Windows.Forms.Label label6;
    }
}