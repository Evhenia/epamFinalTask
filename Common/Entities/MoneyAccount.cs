using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class MoneyAccount
    {
        [Key]
        [ForeignKey("User")]
        public string Id { get; set; }

        public decimal Count { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }

        public virtual User User { get; set; }
    }
}
