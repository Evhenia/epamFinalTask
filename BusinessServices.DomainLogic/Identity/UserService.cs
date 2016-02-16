using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using BusinessServices.DomainLogic.Interfaces.Identity;
using BusinessServices.DomainLogic.Models;
using Common.Entities;
using DataAccess.SqlServer.Core;
using System.Security.Claims;

namespace BusinessServices.DomainLogic.Identity
{
    public class UserService : IUserService
    {
        private UnitOfWork _dataBase;

        public UserService(UnitOfWork unitOfWork)
        {
            _dataBase = unitOfWork;
        }

        public async Task<OperationDetails> Create(AuthUser authUser)
        {
            User user = await _dataBase.UserManager.FindByEmailAsync(authUser.Email);
            if(user == null)
            {
                user = new User() { Email = authUser.Email, UserName = authUser.UserName };
                await _dataBase.UserManager.CreateAsync(user, authUser.Password);
                //add Role
                _dataBase.Save();
                return new OperationDetails(true, "Пользователь создан. Операция произошла успешно.", "Email");
            }
            else
            {
                return new OperationDetails(false, "Пользователь с такой почтой уже существует.", "Email");
            }
        }

        public async Task<ClaimsIdentity> Authenticate(AuthUser authUser)
        {
            ClaimsIdentity claims = null;
            //find User
            User user = await _dataBase.UserManager.FindAsync(authUser.Email, authUser.Password);
            if(user != null)
            {
                claims = await _dataBase.UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            }
            return claims;
        }

        public void Dispose()
        {
            _dataBase.Dispose();
        }
    }
}
