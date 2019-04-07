using System;
using System.Collections.Generic;

namespace Catering.Models
{
    public partial class City
    {
        public City()
        {
            Institutions = new HashSet<Institutions>();
        }

        public int CityId { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }

        public virtual ICollection<Institutions> Institutions { get; set; }
    }
}
