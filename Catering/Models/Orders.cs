using System;
using System.Collections.Generic;

namespace Catering.Models
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public int? InstitutionId { get; set; }

        public virtual Institutions Institution { get; set; }
        public virtual Users User { get; set; }
    }
}
