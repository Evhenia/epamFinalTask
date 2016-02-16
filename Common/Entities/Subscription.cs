using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Subscription
    {
        public int Id { get; set; }

        public int PeriodicalId { get; set; }
        public virtual Periodical Periodical { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public DateTime StartPeriodDate { get; set; }
        public DateTime EndPeriodDate { get; set; }

        public Address Address { get; set; }

        public decimal TotalCost { get; set; }
    }
}
