using System.Threading.Tasks;
using Weeblantis.Core.Models.User;

namespace Weeblantis.Data.Repositories
{
    public interface IUserRepository : IRepository<UserModel>
    {
        UserModel GetByEmail (string Email);
    }
}
