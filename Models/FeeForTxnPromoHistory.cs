using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class FeeForTxnPromoHistory
    {
        public long Id { get; set; }
        public long TxnType { get; set; }
        public int FeeType { get; set; }
        public decimal? MerchantFee { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public string? MerchantId { get; set; }
        public decimal? ConvenienceFee { get; set; }
        public decimal? BankFee { get; set; }
        public decimal? MercFee { get; set; }
        public decimal? ReferrerFee { get; set; }
        public string? CardType { get; set; }
        public bool? IsAcquirerFeeApplicable { get; set; }
        public decimal? AcquirerFee { get; set; }
        public bool? IsFeeRevert { get; set; }
    }
}
