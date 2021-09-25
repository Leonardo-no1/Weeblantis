using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Weeblantis.BusinessLogic.Services.Auth;
using Weeblantis.Core.Models.Auth;

namespace Weeblantis.BusinessLogic.Services.Implementation.Auth
{
    public class AuthService : IAuthService
    {
        private readonly string _secret;
        private readonly string _expDate;
        private readonly string _audience;
        private readonly string _issuer;
        private IConfiguration _config;
        public AuthService(IConfiguration config)
        {
            _secret = config.GetSection("AppSettings").GetSection("JwtConfig").GetSection("secret").Value;
            _expDate = config.GetSection("AppSettings").GetSection("JwtConfig").GetSection("expirationInMinutes").Value;
            _audience = config.GetSection("AppSettings").GetSection("JwtConfig").GetSection("audience").Value;
            _issuer = config.GetSection("AppSettings").GetSection("JwtConfig").GetSection("issuer").Value;
            _config = config;
        }
        public TokenModel GenerateSecurityToken(AuthModel authModel)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(JwtRegisteredClaimNames.Website, authModel.Website),
                    new Claim(JwtRegisteredClaimNames.AuthTime, $"{DateTime.UtcNow.ToLongDateString()} {DateTime.UtcNow.ToLongTimeString()}"),
                    new Claim(JwtRegisteredClaimNames.Aud,_audience),
                    new Claim(JwtRegisteredClaimNames.Iss, _issuer)
                }),
                Expires = DateTime.UtcNow.AddMinutes(double.Parse(_expDate)),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenModel = new TokenModel()
            {
                Token = tokenHandler.WriteToken(token)
            };
            return tokenModel;
        }
    }
}
