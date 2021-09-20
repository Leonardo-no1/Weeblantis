using System.Threading.Tasks;
using Weeblantis.Core.Models.User;

namespace Weeblantis.Data.Repositories
{
    public interface IUserRepository : IRepository<UserModel>
    {
        UserModel GetByUsername(string Username);
        UserModel GetByEmail (string eEmail);

    }
}
