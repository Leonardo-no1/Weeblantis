using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weeblantis.BusinessLogic.Services.Email;
using Weeblantis.Core.Models;
using Weeblantis.Core.Models.Email;

namespace Weeblantis.BusinessLogic.Services.Implementation.Email
{
    public class EmailService: IEmailService
    {
        private readonly AppSettings _appSettings;
        public EmailService(IOptions<AppSettings> options)
        {
            _appSettings = options.Value;
        }
        public async void SendEmail(EmailModel email)
        {
            var apiKey = _appSettings.SendGridApiKey;
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(_appSettings.FromEmail, _appSettings.EmailName);
            var subject = email.Subject;
            var to = new EmailAddress(email.EmailAddress, $"{email.FirstName} {email.LastName}");
            var plainTextContent = "";
            var htmlContent = email.Message;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
