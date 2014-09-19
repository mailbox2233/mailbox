using System;
using System.Collections.Generic;
using System.Text;

namespace mail
{
    class Net
    {
        //登录到我们线上服务器
        private string user_name;
        private string passwd;
        public Net(string c_user_name, string c_passwd)
        {
            user_name = c_user_name;
            passwd = c_passwd;
        }

        public bool connect()
        {
            return true;
        }
    }
}
