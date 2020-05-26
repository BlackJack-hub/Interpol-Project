using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Interpol.Components
{
    class Mail
    {
        static Random random = new Random();
        string secretCode = Convert.ToString(random.Next(100000, 999999));
        string userMail;

        MailAddress fromMail;
        MailAddress toMail;

        public string SecretCode
        {
            get { return secretCode; }
            private set { }
        }
        public Mail() { }

        public Mail(string mail)
        {
            this.userMail = mail;
            this.fromMail = new MailAddress("interpol.application@gmail.com", "Interpol Security System");
            this.toMail = new MailAddress(userMail);
        }

        public void SendMail()
        {
            using(MailMessage mailMessage=new MailMessage(this.fromMail,this.toMail))
            using(SmtpClient smtpClient=new SmtpClient())
            {
                mailMessage.Subject = "Identity Verification";
                mailMessage.IsBodyHtml = false;
                mailMessage.Body = "Login attempted,please enter the security code! Security code: "+secretCode;

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMail.Address, "interpolMAIL");
                smtpClient.Send(mailMessage);
            }
            
        }
    }
}
