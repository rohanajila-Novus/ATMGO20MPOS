using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class DashboardBankDetail
    {
        public string? BankName { get; set; }
        public decimal? TotalTxnAmount { get; set; }
        public int? TotalTxns { get; set; }
        public decimal? MarketShare { get; set; }
    }
}
