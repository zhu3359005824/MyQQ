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
    public partial class Frm_Register : Form
    {
        public Frm_Register()
        {
            InitializeComponent();
        }

        UserDataOperator registerOperator = new UserDataOperator();
         //注册按钮
        private void btnRegister_Click(object sender, EventArgs e)
        {
            #region 注册时验证输入信息 
            if (tbName.Text == "" || tbName.Text.Length > 10)
            {
                MessageBox.Show("昵称输入有误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbName.Focus();
                return;
            }

            if (tbAge.Text == "")
            {
                MessageBox.Show("请输入年龄","提示",MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbAge.Focus();
                return;
            }
            if (!rbtnMan.Checked && !rbtnWoman.Checked)
            {
                MessageBox.Show("请选择性别", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rbtnMan.Focus();
                return;
            }
            if (tbPwd.Text == "")
            {
                MessageBox.Show("请输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPwd.Focus();
                return;

            }

            if (tbPwd.Text != tbPwdAgain.Text)
            {
                MessageBox.Show("两次输入的密码不一致", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPwdAgain.Focus();
                return;

            }
            #endregion
            Random random = new Random();
            int NewQQNumber = random.Next(10000, 100000);
            registerOperator.LoadUserMessage();

            foreach (int item in registerOperator.userMessage.Keys)
            {
                while (NewQQNumber == item)
                {
                    NewQQNumber= random.Next(10000, 100000);
                }
            }

            string sex=rbtnMan.Checked?rbtnMan.Text:rbtnWoman.Text;

           // string test = "insert into myqq_user (Password,Name,Sex,Age,Job,ID) values('00000','小朱','男',21,'学生',10002)";

            string sql = string.Format("insert into myqq_user (Password,Name,Sex,Age,Job,ID) values('{0}','{1}','{2}',{3},'{4}',{5})",tbPwd.Text,tbName.Text,sex,tbAge.Text,cboxJob.Text,NewQQNumber);
            
             int result= registerOperator.InsertUserMessage(sql);

            if (result == 1)
            {
                MessageBox.Show("注册成功!你的QQ号为:" + NewQQNumber, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Frm_Login frm_Login = new Frm_Login();
                frm_Login.ShowDialog();

            }
            else
            {
                MessageBox.Show("注册失败,请重试!","提示",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {
            cboxJob.SelectedIndex = 0;
        }
    }
}
