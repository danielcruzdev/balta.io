using System.Net;
using System.Net.Mail;

namespace Blog.Services
{
    public class EmailService
    {
        public bool Send(
            string toName,
            string toEmail,
            string subject,
            string body,
            string fromName = "Daniel Cruz",
            string fromEmail = "daniel.cruz@outlook.com")
        {
            var smtpClient = new SmtpClient(Configuration.SMTP.Host, Configuration.SMTP.Port)
            {
                Credentials = new NetworkCredential(Configuration.SMTP.UserName, Configuration.SMTP.Password),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = true
            };

            var mail = new MailMessage();
            mail.From = new MailAddress(fromEmail, fromName);
            mail.To.Add(new MailAddress(toEmail, toName));
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            try
            {
                smtpClient.Send(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
