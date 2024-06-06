using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class City
    {
        public int CityId { get; set; }
        public string City1 { get; set; } = null!;
        public string? Classification { get; set; }
        public int ProvinceId { get; set; }

        public virtual Province Province { get; set; } = null!;
    }
}
