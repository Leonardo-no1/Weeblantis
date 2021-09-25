using System;
using System.Collections.Generic;
using System.Text;
using Weeblantis.Core.Models.Auth;

namespace Weeblantis.BusinessLogic.Services.Auth
{
    public interface IAuthService
    {
        TokenModel GenerateSecurityToken(AuthModel authModel);
    }
}
