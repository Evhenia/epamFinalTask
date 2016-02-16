using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SqlServer.Identity;
using DataAccess.SqlServer.Interfaces;
using DataAccess.SqlServer.Repositories;
using Microsoft.AspNet.Identity.EntityFramework;
using Common.Entities;

namespace DataAccess.SqlServer.Core
{
    public class UnitOfWork : IDisposable
    {
        private readonly PeriodicalsDBContext _context;

        private IPeriodicalRepository _periodicalRepository;

        private IThemeRepository _themeRepository;

        private ISubscriptionRepository _subscriptionRepository;

        private IMoneyAccountRepository _moneyAccountRepository;

        private IPaymentRepository _paymentRepository;

        private RoleManager _roleManager;

        private UserManager _userManager;

        public UnitOfWork()
        {
            _context = new PeriodicalsDBContext();
        }

        public UserManager UserManager => _userManager ?? (_userManager = new UserManager(new UserStore<User>(_context)));

        public RoleManager RoleManager => _roleManager ?? (_roleManager = new RoleManager(new RoleStore<Role>(_context)));

        public IPeriodicalRepository PeriodicalRepository => _periodicalRepository ?? (_periodicalRepository = new PeriodicalRepository(_context));

        public IThemeRepository 

    }
}
