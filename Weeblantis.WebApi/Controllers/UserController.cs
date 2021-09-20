using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weeblantis.BusinessLogic.Services;
using Weeblantis.Core.Exceptions;
using Weeblantis.Core.Models.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Weeblantis.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // POST api/<UserController>
        [HttpPost("Register")]
        public ActionResult Register([FromBody] UserDto user)
        {
            _userService.RegisterUser(user);
            return Ok(); 
        }

        // POST api/<UserController>
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
