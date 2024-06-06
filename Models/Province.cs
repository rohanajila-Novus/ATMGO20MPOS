using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class Province
    {
        public Province()
        {
            Cities = new HashSet<City>();
        }

        public int ProvinceId { get; set; }
        public string Province1 { get; set; } = null!;
        public int RegionId { get; set; }

        public virtual Region Region { get; set; } = null!;
        public virtual ICollection<City> Cities { get; set; }
    }
}
