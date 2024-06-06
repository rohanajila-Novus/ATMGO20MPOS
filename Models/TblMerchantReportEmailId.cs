using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TblMerchantReportEmailId
    {
        public long Id { get; set; }
        public string? MerchantId { get; set; }
        public string? MerchantName { get; set; }
        public string? EmailId { get; set; }
        public int? UserId { get; set; }
        public bool? IsEmailSent { get; set; }
        public bool? IsTakenForProcessing { get; set; }
        public string? EmailException { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? ProcedureName { get; set; }
        public string? EmailSubject { get; set; }
        public string? EmailBodyPath { get; set; }
        public int? RetryCount { get; set; }
    }
}
