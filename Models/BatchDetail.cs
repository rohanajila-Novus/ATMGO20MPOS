using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class BatchDetail
    {
        public int Id { get; set; }
        public string? TerminalId { get; set; }
        public int? BatchNo { get; set; }
        public DateTime? BatchBeginDate { get; set; }
        public DateTime? SettledDate { get; set; }
        public bool? IsBatchUpload { get; set; }
        public int? SaleCount { get; set; }
        public decimal? SaleAmount { get; set; }
        public int? RefundCount { get; set; }
        public decimal? RefundAmount { get; set; }
        public int? VoidCount { get; set; }
        public decimal? VoidAmount { get; set; }
        public int? CashCount { get; set; }
        public decimal? CashAmount { get; set; }
        public int? AuthCount { get; set; }
        public decimal? AuthAmount { get; set; }
        public int? DiscountCount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? SaleDiscountAmount { get; set; }
        public decimal? VoidDiscountAmount { get; set; }
        public decimal? CashDiscountAmount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
