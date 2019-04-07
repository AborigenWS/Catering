using System;
using System.Collections.Generic;

namespace Catering.Models
{
    public partial class Deliveries
    {
        public Deliveries()
        {
            Institutions = new HashSet<Institutions>();
        }

        public int DeliveryId { get; set; }
        public decimal? Limit { get; set; }

        public virtual ICollection<Institutions> Institutions { get; set; }
    }
}
