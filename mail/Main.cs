using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Text.RegularExpressions;

namespace mail
{
    public partial class Main : Form
    {
        private User user= new User();

        public Main()
        {
            InitializeComponent();
            _init();
        }

        /*
         * 初始化
         */
        private void _init()
        {
            //发送文件初始化
            SendUser send_user = new SendUser();
            send_user.loadLocalUser(user);
        }

        private void bnt_send_Click(object sender, EventArgs e)
        {
            Email sendemail = new Email("smtp.sohu.com", "qqavmwf@sohu.com", "ezygmpgot", "liujun");
            bool ret = sendemail.sendEmail("egg_0923lj@yeah.net", "明天222上课", "作业非常多", false, false);
            if (ret == true)
            {
                MessageBox.Show("succ");
            }
            else
            {
                MessageBox.Show("fail");
            }
        }

        /*
         * 点击加载发送用户地址
         */
        private void btn_insert_email_Click(object sender, EventArgs e)
        {
            SendUser send_user = new SendUser();
            send_user.loadUser(user);
        }

        /*
         * 登录
         */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool ret = user.connect(textUsername.Text, Util.getMd5(textUserpasswd.Text));
            if (ret == false)
            {
                MessageBox.Show("登录失败!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.baidu.com");
        }
    }
}
