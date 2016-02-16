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
    public class SubscriptionRepository : GenericRepository<Subscription>, ISubscriptionRepository
    {
        private readonly PeriodicalsDBContext _context;

        public SubscriptionRepository(PeriodicalsDBContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
