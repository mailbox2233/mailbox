using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace mail
{
    class SendUser
    {
        private string data_path = "./send_user";

        /*
        * 拆分用户的数据
        */
        private bool _parser_email(User user, string email_line)
        {
            if (email_line == "")
            {
                return false;
            }

            string[] user_info = email_line.Split(new Char[] { '#', '|', ' ', '\t' });
            if (user_info.Length != 2)
            {
                return false;
            }
            else
            {
                //如果没有邮箱
                Regex myregex = new Regex(@"(?<email>[\da-zA-Z_]+@([-\dA-Za-z]+\.)+[a-zA-Z]{2,})");
                if (myregex.IsMatch(user_info[0]) == false)
                {
                    return false;
                }
                else
                {
                    user.userEmailAddr.Add(user_info[0], user_info[1]);
                }
            }
            return true;
        }

        /*
         * 加载文件中记录的用户 
         */
        private bool _load_file_send(User user, string file_name)
        {
            //开始读取文件内容
            FileStream fs = new FileStream(file_name, FileMode.Open, FileAccess.Read);
            StreamReader m_streamReader = new StreamReader(fs);
            m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            string strLine = m_streamReader.ReadLine();
            while (strLine != null)
            {
                if (strLine != "")
                {
                    bool ret = _parser_email(user, strLine.Trim());
                    if (ret == false)
                    {
                        MessageBox.Show(strLine + " fail");
                    }
                    else
                    {
                        //MessageBox.Show(strLine + " succ");
                    }
                }
                strLine = m_streamReader.ReadLine();
            }
            m_streamReader.Close();
            return true;
        }
        
        //加载本地存在的用户列表
        public bool loadLocalUser(User user)
        {
            try
            {
                _load_file_send(user, data_path);
            }
            catch(Exception e)
            {
            }
            return true;
        }


        //加载用户选择的用户
        public bool loadUser(User user)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "";
            string resultFile;
            bool ret;
            openFileDialog1.Filter = "text format.txt|*.txt";
            openFileDialog1.ShowDialog();
            #region 解析数据
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resultFile = openFileDialog1.FileName;
                ret = _load_file_send(user, resultFile);
            }
            #endregion

            //#region 打印日志
            //foreach (KeyValuePair<string, string> kvp in user.userEmailAddr)
            //{
            //    MessageBox.Show(kvp.Key + "\t" + kvp.Value);
            //}
            //#endregion
            return true;
        }
    }
}
