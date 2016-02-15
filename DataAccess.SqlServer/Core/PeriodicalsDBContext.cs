using System.Data.Entity;
using Common.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DataAccess.SqlServer.Core
{
    public class PeriodicalsDBContext : IdentityDbContext<User>
    {

    }
}
