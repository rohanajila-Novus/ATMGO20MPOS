using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class OperationReportTest
    {
        public string? TranDescription { get; set; }
        public string? MerchantId { get; set; }
        public string? MerchantName { get; set; }
        public bool? Active { get; set; }
        public int? Countm { get; set; }
        public string? Month { get; set; }
        public decimal? Amount { get; set; }
        public int? Month1 { get; set; }
    }
}
