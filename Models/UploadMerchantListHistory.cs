using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class UploadMerchantListHistory
    {
        public long Id { get; set; }
        public string? Operation { get; set; }
        public string? BatchNo { get; set; }
        public long? UploadId { get; set; }
        public string? UploadFileName { get; set; }
        public short? FileUploadStatus { get; set; }
        public string? ValidationMsg { get; set; }
        public DateTime? ProcessDate { get; set; }
        public short? IsSuccess { get; set; }
        public int? FileType { get; set; }
        public string? MerchantId { get; set; }
        public string? DateBoarded { get; set; }
        public string? Zone { get; set; }
        public string? MerchantName { get; set; }
        public string? MerchantCount { get; set; }
        public string? Address { get; set; }
        public string? OperatorName { get; set; }
        public string? OperatorContactNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? SlazoningDays { get; set; }
        public string? AgingDays { get; set; }
        public string? NameOnReceipt { get; set; }
        public string? AccountNumber { get; set; }
        public string? MobileNumber { get; set; }
        public string? Nic { get; set; }
        public string? Mcc { get; set; }
        public string? TerminalId { get; set; }
        public string? TerminalType { get; set; }
        public string? Model { get; set; }
        public string? InstalledOperationalDate { get; set; }
        public string? CertificationUpload { get; set; }
        public string? PhoneSerialNumber { get; set; }
        public string? SmartNumber { get; set; }
        public string? SimSerialNumber { get; set; }
        public string? PrinterSerialNumber { get; set; }
        public string? MpospesaPodSerialNumber { get; set; }
        public string? Remarks { get; set; }
        public string? City { get; set; }
        public string? CountryCode { get; set; }
        public byte[]? EncNic { get; set; }
        public string? FeeType { get; set; }
        public decimal? ConvenienceFee { get; set; }
        public decimal? BankFee { get; set; }
        public decimal? MerchantFee { get; set; }
        public decimal? ReferrerFee { get; set; }
        public string? ReferrerName { get; set; }
        public string? ReferralAccountNumber { get; set; }
        public string? ReferralEmailId { get; set; }
        public string? ReferralMobileNumber { get; set; }
        public string? SecEmailId { get; set; }
        public string? CashIn { get; set; }
        public string? Withdraw { get; set; }
        public string? BillPayment { get; set; }
        public string? BalanceInquiry { get; set; }
        public string? ELoad { get; set; }
        public string? Pinchange { get; set; }
        public string? FundTransfer { get; set; }
        public string? TerminalName { get; set; }
        public string? TerminalAddress { get; set; }
        public decimal? BalanceInquiryFee { get; set; }
        public decimal? WithdrawalFee { get; set; }
    }
}
