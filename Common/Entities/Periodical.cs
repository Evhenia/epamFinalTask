using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Periodical
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int CountOfPage { get; set; }

        public int FromYears { get; set; }

        public string Language { get; set; }

        public int TimesAMonth { get; set; }

        //public string Publisher { get; set; }

        public string ImagePath { get; set; }

        public virtual ICollection<Theme> Themes { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
