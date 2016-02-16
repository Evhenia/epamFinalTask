using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessServices.DomainLogic.Models;
using System.Security.Claims;

namespace BusinessServices.DomainLogic.Interfaces.Identity
{
    public interface IUserService : IDisposable
    {
        Task<OperationDetails> Create(AuthUser userDto);

        Task<ClaimsIdentity> Authenticate(AuthUser userDto);
    }
}
