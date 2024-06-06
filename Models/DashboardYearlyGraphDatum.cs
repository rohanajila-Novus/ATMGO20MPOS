using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class DashboardYearlyGraphDatum
    {
        public string? Year { get; set; }
        public int? TransactionCount { get; set; }
        public string? Status { get; set; }
    }
}
