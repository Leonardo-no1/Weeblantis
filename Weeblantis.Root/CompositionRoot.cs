using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Weeblantis.BusinessLogic.Services;
using Weeblantis.BusinessLogic.Services.Implementation;
using Weeblantis.Data;
using Weeblantis.Data.Implementation;
using Weeblantis.Data.Repositories;

namespace Weeblantis.Root
{
    public static class CompositionRoot
    {
        public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("WeeblantisConnectionString")));
            services.AddScoped<DatabaseContext>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
