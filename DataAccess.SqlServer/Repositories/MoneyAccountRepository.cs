using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entities;
using DataAccess.SqlServer.Interfaces;
using DataAccess.SqlServer.Core;

namespace DataAccess.SqlServer.Repositories
{
    public class MoneyAccountRepository : GenericRepository<MoneyAccount>, IMoneyAccountRepository
    {
        private readonly PeriodicalsDBContext _context;

        public MoneyAccountRepository(PeriodicalsDBContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
