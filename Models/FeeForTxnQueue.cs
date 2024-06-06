using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class FeeForTxnQueue
    {
        public long Id { get; set; }
        public int? RequestTypeId { get; set; }
        public int? FormStatusId { get; set; }
        public long? MakerId { get; set; }
        public long? CheckerId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? Remark { get; set; }
        public long TxnType { get; set; }
        public int FeeType { get; set; }
        public decimal? MerchantFee { get; set; }
        public string? MerchantId { get; set; }
        public bool IsDeleted { get; set; }
        public long? FeeId { get; set; }
        public decimal? ConvenienceFee { get; set; }
        public decimal? BankFee { get; set; }
        public decimal? MercFee { get; set; }
        public decimal? ReferrerFee { get; set; }
        public string? CardType { get; set; }
        public bool? IsAcquirerFeeApplicable { get; set; }
        public decimal? AcquirerFee { get; set; }
    }
}
