using System;
using System.Collections.Generic;
using System.Text;
using Weeblantis.Core.Models.Email;

namespace Weeblantis.BusinessLogic.Services
{
    public interface IEmailService
    {
        void SendEmail(Email email);
    }
}
