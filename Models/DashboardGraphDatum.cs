using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class DashboardGraphDatum
    {
        public string? Weekday { get; set; }
        public int? TransactionCount { get; set; }
        public string? Status { get; set; }
    }
}
