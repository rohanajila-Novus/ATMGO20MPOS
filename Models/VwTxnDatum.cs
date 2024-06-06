using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class VwTxnDatum
    {
        public string? TransactionType { get; set; }
        public DateTime? TransactionDateTime { get; set; }
        public decimal? TransactionAmount { get; set; }
        public decimal? TransactionFee { get; set; }
        public string? ResponseCode { get; set; }
        public string? ResponseMsg { get; set; }
        public string? MerchantId { get; set; }
        public string? TerminalId { get; set; }
        public string? MerchantName { get; set; }
        public string? Address { get; set; }
        public string MerchantSettlementAccNumber { get; set; } = null!;
        public string? Rrnnumber { get; set; }
        public string? Apistan { get; set; }
        public string? ReferenceNumber { get; set; }
        public string DebitCardNo { get; set; } = null!;
        public string DebitAccountNo { get; set; } = null!;
        public string CreditCardNo { get; set; } = null!;
        public string CreditAccountNo { get; set; } = null!;
        public string MessageCode { get; set; } = null!;
        public string? BillerName { get; set; }
        public string SubscribersAccountNo { get; set; } = null!;
        public string CardType { get; set; } = null!;
        public string Mdrrate { get; set; } = null!;
        public string Mdramount { get; set; } = null!;
        public string Referror { get; set; } = null!;
        public string ReferralAmount { get; set; } = null!;
        public string? AuthCode { get; set; }
    }
}
