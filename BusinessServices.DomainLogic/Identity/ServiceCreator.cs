using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessServices.DomainLogic.Interfaces.Identity;
using DataAccess.SqlServer.Core;

namespace BusinessServices.DomainLogic.Identity
{
    public class ServiceCreator : IServiceCreator
    {
        public IUserService CreateUserService()//по сути фабрика?
        {
            return new UserService(new UnitOfWork());
        }
    }
}
