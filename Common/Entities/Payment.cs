using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Payment
    {
        public int Id { get; set; }

        public decimal Count { get; set; }

        public DateTime Date { get; set; }

        public string MoneyAccountId { get; set; }
        public MoneyAccount MoneyAccount { get; set; }
    }
}
