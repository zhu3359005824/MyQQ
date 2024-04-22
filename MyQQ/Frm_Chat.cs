using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ.MyQQ_Resource.头像
{
    public partial class Frm_Chat : Form
    {
        public Frm_Chat()
        {
            InitializeComponent();
        }
        public int friendID = 0;
        public string friendName;
        public int friendHeadID;
        public string friendFlag;




        private void Frm_Chat_Load(object sender, EventArgs e)
        {
            this.Text = "与" + friendName + "聊天中...";
            lbChatFriendName.Text = friendName+"("+friendID+")";
            pbFriendHead.Image = imageListHead.Images[friendHeadID];
            rtbMessage.ScrollToCaret();
        }

        private void lbChatFriendName_Click(object sender, EventArgs e)
        {

        }
    }
}
