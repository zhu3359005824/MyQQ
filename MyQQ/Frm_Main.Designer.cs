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
            this.tmAddFriend = new System.Windows.Forms.Timer(this.components);
            this.tmChat = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pboxHead = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lvFriend = new System.Windows.Forms.ListView();
            this.cmsFriendList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAddFriend = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteFriend = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnShowMessage = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAddFriend = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHead)).BeginInit();
            this.cmsFriendList.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            // 
            // tmAddFriend
            // 
            this.tmAddFriend.Interval = 1000;
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
            this.lvFriend.ContextMenuStrip = this.cmsFriendList;
            listViewGroup1.Header = "好友列表";
            listViewGroup1.Name = "好友列表";
            this.lvFriend.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lvFriend.HideSelection = false;
            this.lvFriend.LargeImageList = this.imageListHead;
            this.lvFriend.Location = new System.Drawing.Point(-5, 229);
            this.lvFriend.MultiSelect = false;
            this.lvFriend.Name = "lvFriend";
            this.lvFriend.Size = new System.Drawing.Size(572, 758);
            this.lvFriend.TabIndex = 6;
            this.lvFriend.UseCompatibleStateImageBehavior = false;
            // 
            // cmsFriendList
            // 
            this.cmsFriendList.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsFriendList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddFriend,
            this.tsmDeleteFriend});
            this.cmsFriendList.Name = "cmsFriendList";
            this.cmsFriendList.Size = new System.Drawing.Size(153, 64);
            // 
            // tsmAddFriend
            // 
            this.tsmAddFriend.Name = "tsmAddFriend";
            this.tsmAddFriend.Size = new System.Drawing.Size(152, 30);
            this.tsmAddFriend.Text = "添加好友";
            this.tsmAddFriend.Visible = false;
            // 
            // tsmDeleteFriend
            // 
            this.tsmDeleteFriend.Name = "tsmDeleteFriend";
            this.tsmDeleteFriend.Size = new System.Drawing.Size(152, 30);
            this.tsmDeleteFriend.Text = "删除好友";
            this.tsmDeleteFriend.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnShowMessage,
            this.tsbtnSearch,
            this.tsbtnAddFriend});
            this.toolStrip1.Location = new System.Drawing.Point(0, 954);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(561, 33);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnShowMessage
            // 
            this.tsbtnShowMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnShowMessage.Image = global::MyQQ.Properties.Resources.个人信息;
            this.tsbtnShowMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShowMessage.Name = "tsbtnShowMessage";
            this.tsbtnShowMessage.Size = new System.Drawing.Size(34, 28);
            this.tsbtnShowMessage.Text = "toolStripButton1";
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSearch.Image = global::MyQQ.Properties.Resources.搜索;
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(34, 28);
            this.tsbtnSearch.Text = "toolStripButton2";
            // 
            // tsbtnAddFriend
            // 
            this.tsbtnAddFriend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddFriend.Image = global::MyQQ.Properties.Resources.添加好友;
            this.tsbtnAddFriend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddFriend.Name = "tsbtnAddFriend";
            this.tsbtnAddFriend.Size = new System.Drawing.Size(34, 28);
            this.tsbtnAddFriend.Text = "toolStripButton3";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::MyQQ.Properties.Resources._92174dbbf82064fbb166b1978e6104a354e96fc7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 987);
            this.Controls.Add(this.toolStrip1);
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
            this.cmsFriendList.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageListHead;
        private System.Windows.Forms.ImageList imageListMessage;
        private System.Windows.Forms.Timer tmMessage;
        private System.Windows.Forms.Timer tmAddFriend;
        private System.Windows.Forms.Timer tmChat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pboxHead;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ListView lvFriend;
        private System.Windows.Forms.ContextMenuStrip cmsFriendList;
        private System.Windows.Forms.ToolStripMenuItem tsmAddFriend;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteFriend;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnShowMessage;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripButton tsbtnAddFriend;
    }
}