using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class MPosTran26112020
    {
        public int TranId { get; set; }
        public string? TerminalId { get; set; }
        public string? MerchantId { get; set; }
        public string? Mti { get; set; }
        public string? BatchNo { get; set; }
        public string? AppResponseCode { get; set; }
        public decimal? TranAmount { get; set; }
        public bool? Settled { get; set; }
        public int? AppReceiptNo { get; set; }
        public string? RequestLogRef { get; set; }
        public DateTime? TransactionDateTime { get; set; }
        public string? ProcessingCode { get; set; }
        public string? SettlementAmount { get; set; }
        public string? TransactionAmount { get; set; }
        public string? TransmissionDateTime { get; set; }
        public string? LocalTranDate { get; set; }
        public string? LocalTranTime { get; set; }
        public string? ExpireDate { get; set; }
        public string? SettlementDate { get; set; }
        public string? Iccdata { get; set; }
        public string? ResponseMti { get; set; }
        public string? AuthCode { get; set; }
        public string? Rrn { get; set; }
        public string? CardNo { get; set; }
        public string? Stan { get; set; }
        public string? Apistan { get; set; }
        public short? TranType { get; set; }
        public string? CardType { get; set; }
        public string? CardMfr { get; set; }
        public string? TransactionFlag { get; set; }
        public string? SubscriberNo { get; set; }
        public string? MerchantType { get; set; }
        public string? AiiccountryCode { get; set; }
        public string? PosentryCode { get; set; }
        public string? CardSequenceNumber { get; set; }
        public string? NetworkInternationalIdentifier { get; set; }
        public string? PosconditionCode { get; set; }
        public string? AccessFeeAmount { get; set; }
        public string? Aiic { get; set; }
        public string? ForwardingInstitutionCode { get; set; }
        public string? SwitchResponseCode { get; set; }
        public string? CardAcceptorNameLocation { get; set; }
        public string? AdditionalData { get; set; }
        public string? SettlementCurrencyCode { get; set; }
        public string? TransactionCurrencyCode { get; set; }
        public string? Pindata { get; set; }
        public string? AdditionalAmounts { get; set; }
        public string? ConvenienceFeeAmount { get; set; }
        public string? OriginalDataElement { get; set; }
        public string? ReplacementAmounts { get; set; }
        public string? ReceivingInstitution { get; set; }
        public string? FromAccount { get; set; }
        public string? ToAccount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string? CardHolderName { get; set; }
        public decimal? AvailableAmount { get; set; }
        public bool? IsReversed { get; set; }
        public string? ReversalResponseCode { get; set; }
        public string? ReversalStan { get; set; }
        public byte[]? Track2 { get; set; }
        public decimal? FeeAmount { get; set; }
        public string? LocalTime12Hour { get; set; }
    }
}
