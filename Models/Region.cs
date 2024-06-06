using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class Region
    {
        public Region()
        {
            InverseIsland = new HashSet<Region>();
            Provinces = new HashSet<Province>();
        }

        public int RegionId { get; set; }
        public string Region1 { get; set; } = null!;
        public int IslandId { get; set; }

        public virtual Region Island { get; set; } = null!;
        public virtual ICollection<Region> InverseIsland { get; set; }
        public virtual ICollection<Province> Provinces { get; set; }
    }
}
