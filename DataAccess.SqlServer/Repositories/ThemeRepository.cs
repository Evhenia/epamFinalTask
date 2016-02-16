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
    public class ThemeRepository : GenericRepository<Theme>, IThemeRepository
    {
        private readonly PeriodicalsDBContext _context;

        public ThemeRepository(PeriodicalsDBContext context)
            :base(context)
        {
            _context = context;
        }
    }   
}
