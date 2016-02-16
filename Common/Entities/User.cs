using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Common.Entities
{
    public class User : IdentityUser
    {
        public DateTime BirthDate { get; set; }

        public Address Address { get; set; }

        [Required]
        public virtual MoneyAccount MoneyAccount { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
