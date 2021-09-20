using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;
using Weeblantis.Core.Exceptions;
using Weeblantis.Core.Models.Dtos;
using Weeblantis.Core.Models.User;
using Weeblantis.Data.Repositories;

namespace Weeblantis.BusinessLogic.Services.Implementation
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void RegisterUser(UserDto userDto)
        {
            try
            {
                var exists = _userRepository.GetByEmail(userDto.Email);
                // generate a 128-bit salt using a cryptographically strong random sequence of nonzero values
                byte[] salty = new byte[128 / 8];
                using (var rngCsp = new RNGCryptoServiceProvider())
                {
                    rngCsp.GetNonZeroBytes(salty);
                }
                // hash the password and salt
                string hashedPassword = HashPassword(salty, userDto.Password);
                UserModel user = new UserModel
                {
                    FirstName = userDto.FirstName,
                    LastName = userDto.LastName,
                    Email = userDto.Email,
                    Username = userDto.Username,
                    HashedPassword = hashedPassword,
                    Salt = Convert.ToBase64String(salty),
                };
                _userRepository.Insert(user);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public bool VerifyPassword(LoginDto loginDto)
        {
            if (string.IsNullOrWhiteSpace(loginDto.Email)) throw new ArgumentNullException("Email");
            if (string.IsNullOrWhiteSpace(loginDto.Password)) throw new ArgumentNullException("Password");

            var user = _userRepository.GetByEmail(loginDto.Email);
            if (user == null) throw new UserNotFoundException($"{loginDto.Email} doesn't exist");

            try
            {
                byte[] salt = Convert.FromBase64String(user.Salt);
                var hashed = HashPassword(salt,loginDto.Password);
                StringComparer comparer = StringComparer.Ordinal;
                return comparer.Equals(user.HashedPassword, hashed);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        private static string HashPassword(byte[] salt, string password)
        {
            // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: password,
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA256,
                    iterationCount: 100000,
                    numBytesRequested: 256 / 8));
        }
    }
}
