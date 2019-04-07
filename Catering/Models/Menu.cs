using System;
using System.Collections.Generic;

namespace Catering.Models
{
    public partial class Menu
    {
        public Menu()
        {
            Institutions = new HashSet<Institutions>();
            MenuDishes = new HashSet<MenuDishes>();
        }

        public int MenuId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Institutions> Institutions { get; set; }
        public virtual ICollection<MenuDishes> MenuDishes { get; set; }
    }
}
