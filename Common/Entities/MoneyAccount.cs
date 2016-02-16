using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class MoneyAccount
    {
        public int Id { get; set; }

        public decimal Count { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
