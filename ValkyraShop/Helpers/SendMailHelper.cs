using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using ValkyraShop.DatabaseDto.Shop;

namespace ValkyraShop.Helpers
{
    public class SendMailHelper
    {
        private SmtpClient smptClient;
        private IConfiguration _configuration;
        public SendMailHelper(IConfiguration configuration)
        {
            _configuration = configuration;            
            smptClient = new SmtpClient(_configuration.GetValue<string>("SMTP_URL"));
            smptClient.Port = _configuration.GetValue<int>("SMTP_PORT");
            smptClient.EnableSsl = true;
            smptClient.UseDefaultCredentials = false;
            smptClient.Credentials = new NetworkCredential() { UserName = _configuration.GetValue<string>("SMTP_USERNAME"), Password = _configuration.GetValue<string>("SMTP_PASSWORD") };
        }

        public void SendMail(CustomerWebAccount customerWebAccount, EmailValidation emailValidation)
        {
            MailMessage mailMessage = new MailMessage(_configuration.GetValue<string>("SMTP_USERNAME"), customerWebAccount.Email);
            mailMessage.Body = "blah blub: " + _configuration.GetValue<string>("VALIDATION_URL") + emailValidation.ValidationId;
            mailMessage.Subject = "Valkyra Shop Email validation Link";
            smptClient.Send(mailMessage);
        }
    }
}
