using System;
using System.Collections.Generic;

namespace Catering.Models
{
    public partial class Dishes
    {
        public Dishes()
        {
            DishesIngredients = new HashSet<DishesIngredients>();
            MenuDishes = new HashSet<MenuDishes>();
        }

        public int DishId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public byte? Type { get; set; }

        public virtual ICollection<DishesIngredients> DishesIngredients { get; set; }
        public virtual ICollection<MenuDishes> MenuDishes { get; set; }
    }
}
