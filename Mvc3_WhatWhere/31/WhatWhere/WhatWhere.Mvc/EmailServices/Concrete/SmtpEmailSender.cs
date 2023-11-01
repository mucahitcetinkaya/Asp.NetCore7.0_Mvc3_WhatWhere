using BooksApp.MVC.EmailServices.Abstract;
using System.Net;
using System.Net.Mail;

namespace BooksApp.MVC.EmailServices.Concrete
{
    public class SmtpEmailSender : IEmailSender
    {
        private readonly string _host;
        private readonly int _port;
        private readonly string _username;
        private readonly string _password;
        private readonly bool _enableSsl;

        public SmtpEmailSender(string host, int port, string username, string password, bool enableSsl)
        {
            _host = host;
            _port = port;
            _username = username;
            _password = password;
            _enableSsl = enableSsl;
        }

        public async Task SendEmailAsync(string emailAdress, string subject, string emailBody)
        {
            SmtpClient client = new SmtpClient(_host, _port)
            {
                Credentials = new NetworkCredential(_username, _password),
                EnableSsl = _enableSsl
            };
            MailMessage mailMessage = new MailMessage(_username,emailAdress, subject, emailBody)
            {
                IsBodyHtml = true
            };
            await client.SendMailAsync(mailMessage);
            
        }
    }
}
