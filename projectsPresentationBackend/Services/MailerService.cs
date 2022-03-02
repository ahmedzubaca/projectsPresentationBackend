using ArchitecturalProjectsBackend.Interfaces;
using System;
using System.Threading.Tasks;
using ArchitecturalProjectsBackend.Models;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace ArchitecturalProjectsBackend.Services
{
    public class MailerService : IMailer
    {
        private readonly IConfiguration _config;
        public MailerService(IConfiguration config)
        {
            _config = config;
        }
        public async Task SendEmailAsync(ContactFormUserInfo userInfo)
        {            
            var apiKey = _config["SendGrid : ApiKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("merjema.website@gmail.com", "Website");
            var subject = "Message from Website";
            var to = new EmailAddress("merjema.website@gmail.com");
            var htmlContent = $"{userInfo.FirstName} {userInfo.LastName}<br/>" +
                    $"{userInfo.Email} <br/> <br/>" +
                    $"{userInfo.Message}";
            var plainTextContent = "";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);            
        }
    }
}
