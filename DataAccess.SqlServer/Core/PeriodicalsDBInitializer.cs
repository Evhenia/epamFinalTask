using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SqlServer.Core
{
    public class PeriodicalsDBInitializer : CreateDatabaseIfNotExists<PeriodicalsDBContext>
    {
        protected override void Seed(PeriodicalsDBContext context)
        {
            base.Seed(context);
        }
    }
}
