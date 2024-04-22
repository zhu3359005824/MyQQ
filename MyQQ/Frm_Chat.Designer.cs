namespace MyQQ.MyQQ_Resource.头像
{
    partial class Frm_Chat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Chat));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lbChatFriendName = new System.Windows.Forms.Label();
            this.pbFriendHead = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.rtbSendMessage = new System.Windows.Forms.RichTextBox();
            this.tmShowMessage = new System.Windows.Forms.Timer(this.components);
            this.imageListHead = new System.Windows.Forms.ImageList(this.components);
            this.btnShowAllMessage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFriendHead)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(645, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 796);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSendMessage.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSendMessage.Location = new System.Drawing.Point(521, 638);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(107, 54);
            this.btnSendMessage.TabIndex = 1;
            this.btnSendMessage.Text = "发送";
            this.btnSendMessage.UseVisualStyleBackColor = false;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lbChatFriendName
            // 
            this.lbChatFriendName.AutoSize = true;
            this.lbChatFriendName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbChatFriendName.Location = new System.Drawing.Point(111, 46);
            this.lbChatFriendName.Name = "lbChatFriendName";
            this.lbChatFriendName.Size = new System.Drawing.Size(0, 28);
            this.lbChatFriendName.TabIndex = 2;
            this.lbChatFriendName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbChatFriendName.Click += new System.EventHandler(this.lbChatFriendName_Click);
            // 
            // pbFriendHead
            // 
            this.pbFriendHead.Location = new System.Drawing.Point(12, 12);
            this.pbFriendHead.Name = "pbFriendHead";
            this.pbFriendHead.Size = new System.Drawing.Size(95, 95);
            this.pbFriendHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFriendHead.TabIndex = 3;
            this.pbFriendHead.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "-----------------------------------------------------------------------\r\n";
            // 
            // rtbMessage
            // 
            this.rtbMessage.BackColor = System.Drawing.Color.Azure;
            this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMessage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbMessage.Location = new System.Drawing.Point(-5, 123);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbMessage.Size = new System.Drawing.Size(644, 391);
            this.rtbMessage.TabIndex = 5;
            this.rtbMessage.Text = "";
            // 
            // rtbSendMessage
            // 
            this.rtbSendMessage.BackColor = System.Drawing.Color.Azure;
            this.rtbSendMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSendMessage.Location = new System.Drawing.Point(12, 530);
            this.rtbSendMessage.Name = "rtbSendMessage";
            this.rtbSendMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbSendMessage.Size = new System.Drawing.Size(492, 245);
            this.rtbSendMessage.TabIndex = 6;
            this.rtbSendMessage.Text = "";
            // 
            // tmShowMessage
            // 
            this.tmShowMessage.Enabled = true;
            this.tmShowMessage.Interval = 2000;
            this.tmShowMessage.Tick += new System.EventHandler(this.tmShowMessage_Tick);
            // 
            // imageListHead
            // 
            this.imageListHead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListHead.ImageStream")));
            this.imageListHead.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListHead.Images.SetKeyName(0, "1.jpeg");
            this.imageListHead.Images.SetKeyName(1, "2.jpeg");
            this.imageListHead.Images.SetKeyName(2, "3.jpg");
            this.imageListHead.Images.SetKeyName(3, "4.jpeg");
            this.imageListHead.Images.SetKeyName(4, "5.jpeg");
            // 
            // btnShowAllMessage
            // 
            this.btnShowAllMessage.BackColor = System.Drawing.Color.SkyBlue;
            this.btnShowAllMessage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowAllMessage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowAllMessage.Location = new System.Drawing.Point(521, 553);
            this.btnShowAllMessage.Name = "btnShowAllMessage";
            this.btnShowAllMessage.Size = new System.Drawing.Size(107, 34);
            this.btnShowAllMessage.TabIndex = 7;
            this.btnShowAllMessage.Text = "消息记录";
            this.btnShowAllMessage.UseVisualStyleBackColor = false;
            this.btnShowAllMessage.Click += new System.EventHandler(this.btnShowAllMessage_Click);
            // 
            // Frm_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 798);
            this.Controls.Add(this.btnShowAllMessage);
            this.Controls.Add(this.rtbSendMessage);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbFriendHead);
            this.Controls.Add(this.lbChatFriendName);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Frm_Chat";
            this.Text = "Frm_Chat";
            this.Load += new System.EventHandler(this.Frm_Chat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFriendHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label lbChatFriendName;
        private System.Windows.Forms.PictureBox pbFriendHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.RichTextBox rtbSendMessage;
        private System.Windows.Forms.Timer tmShowMessage;
        private System.Windows.Forms.ImageList imageListHead;
        private System.Windows.Forms.Button btnShowAllMessage;
    }
}