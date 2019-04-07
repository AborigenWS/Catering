using System;
using System.Collections.Generic;

namespace Catering.Models
{
    public partial class Ingredients
    {
        public Ingredients()
        {
            DishesIngredients = new HashSet<DishesIngredients>();
        }

        public int IngredientId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DishesIngredients> DishesIngredients { get; set; }
    }
}
