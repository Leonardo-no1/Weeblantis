using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Weeblantis.BusinessLogic.Services.Implementation.Email;
using Weeblantis.BusinessLogic.Services.Implementation.User;
using Weeblantis.BusinessLogic.Services.Email;
using Weeblantis.BusinessLogic.Services.User;
using Weeblantis.Data;
using Weeblantis.Data.Implementation;
using Weeblantis.Data.Repositories;
using Weeblantis.BusinessLogic.Services.Product;
using Weeblantis.BusinessLogic.Services.Implementation.Product;
using Weeblantis.BusinessLogic.Services.Auth;
using Weeblantis.BusinessLogic.Services.Implementation.Auth;

namespace Weeblantis.Root
{
    public static class CompositionRoot
    {
        public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            #region DatabaseContext
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("WeeblantisConnectionString")));
            services.AddScoped<DatabaseContext>();

            #endregion

            #region Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductCategoryService, ProductCategoryService>();

            #endregion

            #region Repositories
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUserRepository, UserRepository>();

            #endregion

        }
    }
}
