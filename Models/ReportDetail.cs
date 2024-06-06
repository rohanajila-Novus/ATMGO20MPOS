using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class ReportDetail
    {
        public int TranId { get; set; }
        public string? MerchantName { get; set; }
        public string? MerchantId { get; set; }
        public string LocationBranch { get; set; } = null!;
        public string? MerchSttlmntAcctNo { get; set; }
        public string? TrxnDate { get; set; }
        public string? TrxnTime { get; set; }
        public string? TermId { get; set; }
        public string? TrcNo { get; set; }
        public string? PosAssignTrxnNo { get; set; }
        public string DebitCardNo { get; set; } = null!;
        public string? BinNo { get; set; }
        public string DebitAccountNo { get; set; } = null!;
        public string CreditCardNo { get; set; } = null!;
        public string CreditAccountNo { get; set; } = null!;
        public decimal? TrxnAmount { get; set; }
        public decimal? TrxnFee { get; set; }
        public string? TrxnType { get; set; }
        public string? TrxnCode { get; set; }
        public string? TrxnStat { get; set; }
        public string MsgCode { get; set; } = null!;
        public string? BillerName { get; set; }
        public string SubsAccountNo { get; set; } = null!;
        public string CardType { get; set; } = null!;
        public decimal? DebitTrxnAmount { get; set; }
        public decimal? CreditTrxnAmount { get; set; }
        public string MrdRate { get; set; } = null!;
        public string MrdAmount { get; set; } = null!;
        public string IssuingBankName { get; set; } = null!;
        public string ReferredBy { get; set; } = null!;
        public string ReferrerAccntNo { get; set; } = null!;
        public decimal? ReferrerShare { get; set; }
        public decimal? RcbcShare { get; set; }
        public decimal? MerchantShare { get; set; }
        public string Filler { get; set; } = null!;
        public string? ReferenceNumber { get; set; }
        public decimal? TotalAmountPhp { get; set; }
        public DateTime? TransactionDateTime { get; set; }
    }
}
