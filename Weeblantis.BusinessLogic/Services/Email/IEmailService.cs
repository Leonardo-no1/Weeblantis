using System;
using System.Collections.Generic;
using System.Text;
using Weeblantis.Core.Models.Email;

namespace Weeblantis.BusinessLogic.Services.Email
{
    public interface IEmailService
    {
        void SendEmail(EmailModel email);
    }
}
