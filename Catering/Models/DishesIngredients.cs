using System;
using System.Collections.Generic;

namespace Catering.Models
{
    public partial class DishesIngredients
    {
        public int DishId { get; set; }
        public int IngredientId { get; set; }
        public short Count { get; set; }

        public virtual Dishes Dish { get; set; }
        public virtual Ingredients Ingredient { get; set; }
    }
}
