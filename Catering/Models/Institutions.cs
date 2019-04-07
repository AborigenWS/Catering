using System;
using System.Collections.Generic;

namespace Catering.Models
{
    public partial class Institutions
    {
        public Institutions()
        {
            Orders = new HashSet<Orders>();
        }

        public int InstitutionId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public int? DeliveryId { get; set; }
        public int? MenuId { get; set; }
        public string Image { get; set; }
        public int? CityId { get; set; }

        public virtual City City { get; set; }
        public virtual Deliveries Delivery { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
