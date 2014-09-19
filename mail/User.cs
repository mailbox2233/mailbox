using System;
using System.Collections.Generic;
using System.Text;

namespace mail
{
    class User
    {
        public string username;
        public string passwd;
        public double moneyLeft;
        public double isOnline;
        public Dictionary<string, string> userEmailAddr  = new Dictionary<string,string>();

        public bool connect(string username, string passwd)
        {

            return true;
        }
    }
}
