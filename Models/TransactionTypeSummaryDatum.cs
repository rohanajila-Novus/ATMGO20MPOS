using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TransactionTypeSummaryDatum
    {
        public string? TranType { get; set; }
        public int? Volume { get; set; }
        public decimal? Value { get; set; }
        public decimal? Percentage { get; set; }
    }
}
