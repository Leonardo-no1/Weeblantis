using System.Threading.Tasks;
using Weeblantis.Core.Models.User;
using Weeblantis.Data.Repositories;

namespace Weeblantis.Data.Implementation
{
    public class UserRepository : Repository<UserModel>, IUserRepository
    {
        public UserRepository(DatabaseContext context) : base(context) { }

        public UserModel GetByEmail(string Email)
        {
            return FindByCondition(user => user.Email == Email);
        }
    }
}
