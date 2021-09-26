using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

namespace Weeblantis.WebApi.Extensions
{
    public static class AuthenticationExtension
    {
        public static IServiceCollection AddTokenAuthentication(this IServiceCollection services, IConfiguration config)
        {
            var secret = config.GetSection("AppSettings").GetSection("JwtConfig").GetSection("secret").Value;
            var _issuer = config.GetSection("AppSettings").GetSection("JwtConfig").GetSection("issuer").Value;
            var _audience = config.GetSection("AppSettings").GetSection("JwtConfig").GetSection("audience").Value;
            var key = Encoding.ASCII.GetBytes(secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    // Clock skew compensates for server time drift.
                    // We recommend 5 minutes or less:
                    ClockSkew = TimeSpan.FromMinutes(5),
                    // Specify the key used to sign the token:
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    RequireSignedTokens = true,
                    // Ensure the token hasn't expired:
                    RequireExpirationTime = true,
                    ValidateLifetime = true,
                    // Ensure the token audience matches our audience value (default true):
                    ValidateAudience = true,
                    ValidAudience = _audience,
                    // Ensure the token was issued by a trusted authorization server (default true)
                    ValidateIssuer = true,
                    ValidIssuer = _issuer,

                };
            });

            return services;
        }
    }
}
