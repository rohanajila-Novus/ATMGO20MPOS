using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TblMerchant
    {
        public string MerchantId { get; set; } = null!;
        public string MerchantName { get; set; } = null!;
        public string Balance { get; set; } = null!;
        public string SettlementBalance { get; set; } = null!;
        public string? EmailId { get; set; }
        public bool? Active { get; set; }
        public DateTime? ActivatedOn { get; set; }
        public string? Mobile { get; set; }
        public string UpiVpa { get; set; } = null!;
        public string? Mccid { get; set; }
        public string? SeNumber { get; set; }
        public string? DiscountRate { get; set; }
        public string? Upibank { get; set; }
        public string? Upiid { get; set; }
        public string? ParticipantId { get; set; }
        public string? BankName { get; set; }
        public string? DiscountType { get; set; }
        public string? Fuelcompany { get; set; }
        public string? MerchantType { get; set; }
        public string? MerchantType1 { get; set; }
        public string? SettlementType { get; set; }
        public string? DistributedCode { get; set; }
        public DateTime? DateBoarded { get; set; }
        public string? Zone { get; set; }
        public int? MerchantCount { get; set; }
        public string? Address { get; set; }
        public string? OperatorName { get; set; }
        public string? OperatorContactNumber { get; set; }
        public string? SlazoningDays { get; set; }
        public string? AgingDays { get; set; }
        public string? NameOnReceipt { get; set; }
        public string? AccountNumber { get; set; }
        public string? Nic { get; set; }
        public string? Mcc { get; set; }
        public string? City { get; set; }
        public string? CountryCode { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public byte[]? EncNic { get; set; }
        public int? ReferrerId { get; set; }
        public string? SecEmailId { get; set; }
        public string? PartnerSessionId { get; set; }
        public string? PartnerCode { get; set; }
        public string? Currency { get; set; }
        public string? PartnerMerchantId { get; set; }
        public DateTime? EnrollDatetime { get; set; }
    }
}
