using Common.Entities;
using Microsoft.AspNet.Identity;

namespace DataAccess.SqlServer.Identity
{
    public class RoleManager : RoleManager<Role>
    {
        public RoleManager(IRoleStore<Role, string> store)
                    : base(store)
        { }
    }
}
