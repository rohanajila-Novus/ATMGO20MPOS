using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TblMerchantReportEmailIdArchival
    {
        public long ArchivalId { get; set; }
        public long Id { get; set; }
        public string? MerchantId { get; set; }
        public string? MerchantName { get; set; }
        public string? EmailId { get; set; }
        public long? UserId { get; set; }
        public bool? IsEmailSent { get; set; }
        public bool? IsTakenForProcessing { get; set; }
        public string? EmailException { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? ArchivalCreatedDate { get; set; }
    }
}
