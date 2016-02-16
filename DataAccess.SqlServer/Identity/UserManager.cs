using Common.Entities;
using Microsoft.AspNet.Identity;

namespace DataAccess.SqlServer.Identity
{
    public class UserManager : UserManager<User>
    {
        public UserManager(IUserStore<User> store)
                : base(store)
        {
        }
    }
}
