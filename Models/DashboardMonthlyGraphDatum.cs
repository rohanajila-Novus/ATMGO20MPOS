using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class DashboardMonthlyGraphDatum
    {
        public string? Month { get; set; }
        public int? TransactionCount { get; set; }
        public string? Status { get; set; }
    }
}
