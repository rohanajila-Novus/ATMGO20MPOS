using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class UrbanRuralStatistic
    {
        public string? Island { get; set; }
        public string? Area { get; set; }
        public int? TxnVol { get; set; }
        public decimal? TxnVal { get; set; }
        public decimal? Percentage { get; set; }
    }
}
