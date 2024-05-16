using System;
using System.Collections.Generic;

namespace ZH3B_XEZH7P.Models
{
    public partial class Type
    {
        public Type()
        {
            Cocktails = new HashSet<Cocktail>();
        }

        public byte TypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Cocktail> Cocktails { get; set; }
    }
}
