using System;
using System.Collections.Generic;

namespace ZH3B_XEZH7P.Models
{
    public partial class Cocktail
    {
        public Cocktail()
        {
            Recipes = new HashSet<Recipe>();
        }

        public int CocktailSk { get; set; }
        public string Name { get; set; } = null!;
        public byte? TypeFk { get; set; }
        public decimal Price { get; set; }

        public virtual Type? TypeFkNavigation { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
