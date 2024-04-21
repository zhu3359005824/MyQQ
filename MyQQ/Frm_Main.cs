﻿using MyQQ.MyQQ_Resource.头像;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        //消息的发送者
        int fromUserID;
        //
        int friendHeadID;

        int messageImageIndex = 0;

        public static string name = "";
        public static string strFlag = "[离线]";

        UserDataOperator mainFormDataOperator = new UserDataOperator();

        //显示登陆账户的 头像,昵称,账号信息
        public void ShowInfo()
        {
            int headID = 0;
            string sql = "select Name,HeadID from myqq_user where ID=" + PublicClass.loginID + "";
            MySqlDataReader sqlDataReader = mainFormDataOperator.GetDataReader(sql);
            if (sqlDataReader.Read())
            {
                if (!(sqlDataReader["Name"] is DBNull))
                {
                    name = sqlDataReader["Name"].ToString();
                }
                headID = Convert.ToInt32(sqlDataReader["HeadID"]);
            }
            sqlDataReader.Close();
            UserDataOperator.connection.Close();
            this.Text = PublicClass.loginID.ToString();
            pboxHead.Image = imageListHead.Images[headID];
            lbName.Text = name + "(" + PublicClass.loginID + ")";
        }
        ////显示好友列表
        private void ShowFriendList()
        {

            lvFriend.Items.Clear();
            lvFriend.View = View.Details; // 确保设置了 View 属性

            lvFriend.Columns.Add("好友头像", 150, HorizontalAlignment.Left);


            lvFriend.Columns.Add("好友名称", 50, HorizontalAlignment.Left);
            lvFriend.Columns.Add("状态", 50, HorizontalAlignment.Left);





            lvFriend.SmallImageList = imageListHead;

            // 使用参数化查询来防止SQL注入
            string sql = "SELECT f.FriendID, f.FriendHeadID, f.FriendFlag, u.Name AS FriendName " +
                         "FROM myqq_user_friend f " +
                         "JOIN myqq_user u ON f.FriendID = u.ID " +
                         "WHERE f.ID = " + PublicClass.loginID;

            MySqlDataReader mySqlDataReader = mainFormDataOperator.GetDataReader(sql);


            int i = lvFriend.Items.Count;
            while (mySqlDataReader.Read())
            {

                int friendID = Convert.ToInt32(mySqlDataReader["FriendID"]);
                string strFriendName = mySqlDataReader["FriendName"].ToString();
                string strFriendFlag = mySqlDataReader["FriendFlag"].ToString();
                string strStatus = strFriendFlag == "n" ? "[离线]" : "[在线]";

                // 添加项到 ListView
                ListViewItem lvi = new ListViewItem(new string[] { strFriendName + strStatus, friendID.ToString() });
                lvFriend.Items.Add(lvi);
                lvi.ImageIndex = Convert.ToInt32(mySqlDataReader["FriendHeadID"]);
                lvFriend.Items[i].Group = lvFriend.Groups[0];
                i++;
            }


            mySqlDataReader.Close();
            UserDataOperator.connection.Close();

        }


        private void Frm_Main_Load(object sender, EventArgs e)
        {
            ShowInfo();
            ShowFriendList();
        }

        private void Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
        Frm_Chat chat;
        private void lvFriend_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lvFriend.Items.Count > 0)
            {
                chat=new Frm_Chat();
                chat.Show();
            } 
        }
    }
}
