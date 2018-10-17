using System;
using System.Net.Mail;

namespace EMApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SendEmail("This is the test mail from Openshift");
        }

        static void SendEmail(string _Content)
        {
            try
            {
                string _FromAddress = "emailv1infotech@gmail.com";
                string _ToAddress = "manbtechit@gmail.com";

                MailMessage mail = new MailMessage(_FromAddress, _ToAddress);
                SmtpClient client = new SmtpClient();
                client.Port = 25;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;

                client.Credentials = new System.Net.NetworkCredential("emailv1infotech@gmail.com", "V1InfoTech");
                mail.IsBodyHtml = true;
                mail.Subject = "Openshift : Contact";
                mail.Body = _Content;
                client.Send(mail);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
