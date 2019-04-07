using System;
using System.Collections.Generic;

namespace Catering.Models
{
    public partial class MenuDishes
    {
        public int MenuId { get; set; }
        public int DishId { get; set; }
        public byte Weight { get; set; }
        public decimal? Price { get; set; }

        public virtual Dishes Dish { get; set; }
        public virtual Menu Menu { get; set; }
    }
}
