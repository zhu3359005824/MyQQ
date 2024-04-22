namespace MyQQ
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("好友列表", System.Windows.Forms.HorizontalAlignment.Left);
            this.imageListHead = new System.Windows.Forms.ImageList(this.components);
            this.imageListMessage = new System.Windows.Forms.ImageList(this.components);
            this.tmMessage = new System.Windows.Forms.Timer(this.components);
            this.tmChat = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pboxHead = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lvFriend = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHead)).BeginInit();
            this.SuspendLayout();
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
            // imageListMessage
            // 
            this.imageListMessage.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageListMessage.ImageSize = new System.Drawing.Size(24, 24);
            this.imageListMessage.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tmMessage
            // 
            this.tmMessage.Enabled = true;
            this.tmMessage.Interval = 5000;
            this.tmMessage.Tick += new System.EventHandler(this.tmMessage_Tick);
            // 
            // tmChat
            // 
            this.tmChat.Interval = 500;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(486, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 33);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(520, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 33);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pboxHead
            // 
            this.pboxHead.Image = global::MyQQ.Properties.Resources._4;
            this.pboxHead.Location = new System.Drawing.Point(31, 56);
            this.pboxHead.Name = "pboxHead";
            this.pboxHead.Size = new System.Drawing.Size(130, 124);
            this.pboxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxHead.TabIndex = 4;
            this.pboxHead.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbName.Location = new System.Drawing.Point(189, 69);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(82, 24);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "label1";
            // 
            // lvFriend
            // 
            this.lvFriend.BackColor = System.Drawing.Color.LightSteelBlue;
            listViewGroup1.Header = "好友列表";
            listViewGroup1.Name = "好友列表";
            this.lvFriend.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lvFriend.HideSelection = false;
            this.lvFriend.LargeImageList = this.imageListHead;
            this.lvFriend.Location = new System.Drawing.Point(-5, 186);
            this.lvFriend.MultiSelect = false;
            this.lvFriend.Name = "lvFriend";
            this.lvFriend.Size = new System.Drawing.Size(572, 801);
            this.lvFriend.TabIndex = 6;
            this.lvFriend.UseCompatibleStateImageBehavior = false;
            this.lvFriend.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvFriend_MouseDoubleClick);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::MyQQ.Properties.Resources._92174dbbf82064fbb166b1978e6104a354e96fc7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 987);
            this.Controls.Add(this.lvFriend);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pboxHead);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1200, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MyQQ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Main_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageListHead;
        private System.Windows.Forms.ImageList imageListMessage;
        private System.Windows.Forms.Timer tmMessage;
        private System.Windows.Forms.Timer tmChat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pboxHead;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ListView lvFriend;
    }
}