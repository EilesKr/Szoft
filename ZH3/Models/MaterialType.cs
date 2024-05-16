using System;
using System.Collections.Generic;

namespace ZH3B_XEZH7P.Models
{
    public partial class MaterialType
    {
        public MaterialType()
        {
            Materials = new HashSet<Material>();
        }

        public byte MaterialTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Material> Materials { get; set; }
    }
}
