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
    public class PeriodicalRepository : GenericRepository<Periodical>, IPeriodicalRepository
    {
        private readonly PeriodicalsDBContext _context;

        public PeriodicalRepository(PeriodicalsDBContext context)
            : base(context)
        {
            _context = context;
        }
    }
}

