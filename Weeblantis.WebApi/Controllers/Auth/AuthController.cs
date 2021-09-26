using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weeblantis.BusinessLogic.Services.Auth;
using Weeblantis.Core.Models.Auth;

namespace Weeblantis.WebApi.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("Authenticate")]
        public ActionResult<TokenModel> Authenticate([FromBody] AuthModel authModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var token = _authService.GenerateSecurityToken(authModel);
            return Ok(token);
        }
    }
}
