using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;

namespace mail
{
    class Email
    {
        private MailMessage msg;
        private SmtpClient client;
        private string host;
        private string send_addr;

        public Email(string c_host, string c_send_addr, string c_send_passwd, string c_send_uname = "", int c_port = 25, bool c_needssl = false)
        {
            host = c_host;
            send_addr = c_send_addr;
            msg = new MailMessage();
            msg.From = new MailAddress(c_send_addr, c_send_uname, System.Text.Encoding.UTF8);
            client = new SmtpClient(c_host, c_port);
            client.Credentials = new System.Net.NetworkCredential(c_send_addr, c_send_passwd);
            client.EnableSsl = c_needssl;
        }

        public bool sendEmail(string send_addr, string send_subject, string send_conent, bool aysn = false, bool needprefix = true)
        {
            MessageBox.Show(send_addr);
            msg.To.Add(send_addr);
            msg.Subject = send_subject;//邮件标题   
            msg.SubjectEncoding = System.Text.Encoding.UTF8;//邮件标题编码   
            msg.Body = send_conent;//邮件内容   
            msg.BodyEncoding = System.Text.Encoding.UTF8;//邮件内容编码   
            msg.IsBodyHtml = true;//是否是HTML邮件   
            msg.Priority = MailPriority.High;//邮件优先级   
            try
            {
                if (aysn == true)
                {
                    object userState = msg;
                    client.SendAsync(msg, userState);
                }
                else 
                {
                    client.Send(msg);
                }               
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                return false;
            }   
            return true;
        }
    }
}
