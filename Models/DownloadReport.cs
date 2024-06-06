using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class DownloadReport
    {
        public string? MerchantName { get; set; }
        public string? MerchantId { get; set; }
        public string? TerminalId { get; set; }
        public string? SettlementAccNo { get; set; }
        public string? TraceNumber { get; set; }
        public string? TransactionType { get; set; }
        public string? TransactionDate { get; set; }
        public string? TransactionTime { get; set; }
        public decimal? TransactionAmountPhp { get; set; }
        public decimal? TotalAmountPhp { get; set; }
        public string? TransactionStatus { get; set; }
        public string CardType { get; set; } = null!;
        public string? ReferenceNumber { get; set; }
        public string DebitCardNo { get; set; } = null!;
        public string? BinNo { get; set; }
        public string DebitAccountNo { get; set; } = null!;
        public string CreditCardNo { get; set; } = null!;
        public string CreditAccountNo { get; set; } = null!;
        public decimal? TransactionFee { get; set; }
        public string LocationBranch { get; set; } = null!;
        public string? ResponseCode { get; set; }
        public string MessageCode { get; set; } = null!;
        public string? BillerName { get; set; }
        public string SubscriberSAccountNo { get; set; } = null!;
        public string? PosAssignedTxnNo { get; set; }
        public decimal? DebitTranAmount { get; set; }
        public decimal? CreditTranAmount { get; set; }
        public string MdrRate { get; set; } = null!;
        public string MdrAmount { get; set; } = null!;
        public string IssuingBankName { get; set; } = null!;
        public string ReferredBy { get; set; } = null!;
        public string ReferrerAccountNo { get; set; } = null!;
        public decimal? ReferrerFeeShare { get; set; }
        public decimal? RcbcShare { get; set; }
        public decimal? MerchantShare { get; set; }
    }
}
