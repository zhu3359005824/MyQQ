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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.BringToFront();
            Frm_Register frm_Register = new Frm_Register();
            frm_Register.ShowDialog();
        }



        

        //检测输入
        public bool CheckUserMessageInput()
        {
            if (username.Text == "")
            {
                MessageBox.Show("请输入账号", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (Convert.ToUInt32(username.Text) > 99999)
            {
                MessageBox.Show("请输入正确的账号", "登陆提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                username.Focus();
                return false;
            }
            else if (userpassword.Text == "")
            {
                MessageBox.Show("请输入密码", "登陆提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userpassword.Focus();
                return false;
            }


            else
            {
                return true;
            }

        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

            SQLOperator.GetUserInfoById(SQLOperator.GetRememberUserIds());
            //标志位为true,则自动填充
            if (SQLOperator.IsRemember == true)
            {
                cboxRemember.Checked = true;

                foreach (var item in SQLOperator.RememberUser)
                {
                    username.Text = item.Key.ToString();
                    userpassword.Text = item.Value.ToString();
                   
                }
                
            }
            
        }

     

        UserDataOperator SQLOperator = new UserDataOperator();

        public void Login()
        {
            //实现用户登录
            if (CheckUserMessageInput())
            {
                bool tag = false;
                SQLOperator.LoadUserMessage();


                foreach (var item in SQLOperator.userMessage)
                {

                    if (Convert.ToInt32(username.Text) == item.Key && userpassword.Text == item.Value)
                    {
                        if (!SQLOperator. savedUserMessage.ContainsKey(item.Key))
                        {
                            SQLOperator.savedUserMessage.Add(item.Key, item.Value);
                        }

                       
                        tag = true;
                        Frm_Main frm_Main = new Frm_Main();
                        frm_Main.Show();
                        this.Visible = false;
                    }
                }
                if (tag == false)
                {
                    MessageBox.Show("输入的用户名或密码有误!", "登陆提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }
        private void pboxLogin_Click(object sender, EventArgs e)
        {
           
           Login();
            
        }

        //username输入检测
        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能输入数字
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\r' || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //userpassword输入检测
        private void userpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                pboxLogin_Click (sender, e);
            }
        }

        private void cboxLogin_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cboxRemember_CheckedChanged(object sender, EventArgs e)
        {
            
            if(username.Text.Length!=0)
            { SQLOperator.SetRememberStatus(Convert.ToInt32(username.Text)); }
           
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkRegister_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Register frm_Register = new Frm_Register();
            frm_Register.ShowDialog();
        }

        private void linkFindPWD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void PboxMin_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

