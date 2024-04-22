using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.X509;
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
            lbChatFriendName.Text = friendName + "(" + friendID + ")";
            pbFriendHead.Image = imageListHead.Images[friendHeadID];
            rtbMessage.ScrollToCaret();
        }

        private void lbChatFriendName_Click(object sender, EventArgs e)
        {

        }

        UserDataOperator dataoperator = new UserDataOperator();
        private void btnSendMessage_Click(object sender, EventArgs e)
        {


            if (rtbSendMessage.Text == "")
            {
                MessageBox.Show("请输入要发送的内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //MessageState 为0,表示未读消息  为1,表示已读消息 
                //MessageTypeId 为1,表示聊天消息   为0,表示添加好友消息
                string sql = string.Format("insert into myqq_message (FromUserID,ToUserID,Message,MessageState,MessageTime) values({0},{1},{2},{3},{4})", PublicClass.loginID, friendID, "'" + rtbSendMessage.Text + "'", 0, "'" + DateTime.Now + "'");

                int result = dataoperator.ChangeSQL(sql);
                //rtbMessage.Text = "\n" + Frm_Main.name + "     " + DateTime.Now + "\n  " + rtbSendMessage.Text + "\n";

                rtbMessage.AppendText(string.Format("{0} {1}\n  {2}\n", Frm_Main.name, DateTime.Now, rtbSendMessage.Text));
                //发送失败
                if (result != 1)
                {
                    MessageBox.Show("消息发送失败,请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                rtbSendMessage.Text = "";
                rtbSendMessage.Focus();




            }
        }
        //未读信息变已读
        private void ChangeMessageState(string fromUserID)
        {
            string[] messages = fromUserID.Split('_');

            string sql = "update myqq_message set MessageState=1 where FromUserID=";

            foreach(string id in messages)
            {
                if (id != "")
                {
                    sql += id;
                    dataoperator.ChangeSQL(sql);
                }
            }


        }
        //聊天窗体显示交流信息
        private void ShowMessage()
        {
            //保存发送信息人的ID
            string messageID = "";
            string message;
            string messageTime;

            string sql = "select FromUserID,Message,MessageTime from myqq_message where FromUserID=" + friendID +
                " and ToUserID=" + PublicClass.loginID + " and MessageState=0";
            MySqlDataReader dataReader = dataoperator.GetDataReader(sql);
            while (dataReader.Read())
            {
                messageID += dataReader["FromUserID"] + "_";
                message = dataReader["Message"].ToString();
                messageTime = Convert.ToDateTime(dataReader["MessageTime"]).ToString();


                rtbMessage.AppendText(string.Format("{0} {1}\n  {2}\n", friendName, messageTime, message));
               // rtbMessage.Text = "\n" + friendName + "    " + messageTime + "\n" + message + "";
            }
            dataReader.Close();
            UserDataOperator.connection.Close();
            //是否存在信息
            if(messageID.Length > 1)
            {
                messageID.Remove(messageID.Length - 1);//去掉最后的连接符
                ChangeMessageState(messageID);
            }



        }

        private void tmShowMessage_Tick(object sender, EventArgs e)
        {
            ShowMessage();
        }

        private void btnShowAllMessage_Click(object sender, EventArgs e)
        {
            rtbMessage.Clear();
            int messageID ;
            string message;
            string messageTime;
            string messageSendName="";

            string sql = "SELECT  m.FromUserID, u.`Name` AS SenderName, m.Message,m.MessageTime FROM myqq_message m JOIN myqq_user u ON m.FromUserID = u.ID WHERE((m.FromUserID = "+friendID+" AND m.ToUserID ="+ PublicClass.loginID+") OR(m.FromUserID = "+PublicClass.loginID+" AND m.ToUserID = "+friendID+"))ORDER BY m.MessageTime ASC"; 

            // SELECT  m.FromUserID, u.`Name` AS SenderName,m.Message,m.MessageTime FROM myqq_message m JOIN myqq_user u ON m.FromUserID = u.ID WHERE ((m.FromUserID = 11111 AND m.ToUserID = 10000) OR(m.FromUserID = 10000 AND m.ToUserID = 11111))ORDER BY m.MessageTime ASC;
            MySqlDataReader dataReader = dataoperator.GetDataReader(sql);
            while (dataReader.Read())
            {
                messageID = Convert.ToInt32(dataReader["FromUserID"]);
                message = dataReader["Message"].ToString();
                messageTime = Convert.ToDateTime(dataReader["MessageTime"]).ToString();
                messageSendName = dataReader["SenderName"].ToString();
                

                rtbMessage.AppendText(string.Format("{0} {1}\n  {2}\n", messageSendName, messageTime, message));
                // rtbMessage.Text = "\n" + friendName + "    " + messageTime + "\n" + message + "";
            }
            dataReader.Close();
            UserDataOperator.connection.Close();
        }
    }
}
