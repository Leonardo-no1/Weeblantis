using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weeblantis.Core.Models.Dtos;

namespace Weeblantis.BusinessLogic.Services
{
    public interface IUserService
    {
        public void RegisterUser(UserDto userDto);
        public bool VerifyPassword(LoginDto loginDto);
    }
}
