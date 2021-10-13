using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weeblantis.Core.Dtos;

namespace Weeblantis.BusinessLogic.Services.User
{
    public interface IUserService
    {
        public void RegisterUser(UserDto userDto);
        public bool VerifyPassword(LoginDto loginDto);
        public UserDto GetUser(string email);
    }
}
