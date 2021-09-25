using Microsoft.AspNetCore.Mvc;
using Weeblantis.BusinessLogic.Services.User;
using Weeblantis.Core.Exceptions;
using Weeblantis.Core.Dtos;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Weeblantis.WebApi.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // POST api/Register
        [HttpPost("Register")]
        public ActionResult Register([FromBody] UserDto user)
        {
            if (!ModelState.IsValid) {
                return BadRequest();
            }
            _userService.RegisterUser(user);
            return Ok();
        }

        // POST api/Login
        [HttpPost("Login")]
        public ActionResult Login([FromBody] LoginDto login)
        {
            try
            {
                return Ok(_userService.VerifyPassword(login));
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
