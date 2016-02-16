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

        public IThemeRepository ThemeRepository => _themeRepository ?? (_themeRepository = new ThemeRepository(_context));

        public ISubscriptionRepository SubscriptionRepository => _subscriptionRepository ?? (_subscriptionRepository = new SubscriptionRepository(_context));

        public IMoneyAccountRepository MoneyAccountRepository => _moneyAccountRepository ?? (_moneyAccountRepository = new MoneyAccountRepository(_context));

        public IPaymentRepository PaymentRepository => _paymentRepository ?? (_paymentRepository = new PaymentRepository(_context));
        
        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
