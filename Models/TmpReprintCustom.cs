using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TmpReprintCustom
    {
        public string? TranTime { get; set; }
        public string? CardNo { get; set; }
        public string? TranType { get; set; }
        public string? AuthCode { get; set; }
        public string? TranAmount { get; set; }
        public string? FeeAmount { get; set; }
        public string? Stan { get; set; }
        public string? BatchNo { get; set; }
        public string? Rrn { get; set; }
        public string? CardHolderName { get; set; }
        public string? SubscriberNo { get; set; }
        public string? TransactionDate { get; set; }
        public string? ToAccount { get; set; }
        public string? AvailableAmount { get; set; }
        public string? TotalAmount { get; set; }
        public string? AvailableTotal { get; set; }
        public string? TransactionFlag { get; set; }
        public string? CardType { get; set; }
        public string? InstituteName { get; set; }
    }
}
