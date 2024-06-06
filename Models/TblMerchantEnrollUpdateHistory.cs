using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TblMerchantEnrollUpdateHistory
    {
        public long Id { get; set; }
        public string? TranType { get; set; }
        public string? MerchantId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? ApiresponseCode { get; set; }
        public string? ApiresponseMsg { get; set; }
        public DateTime? ApiresponseDtTime { get; set; }
    }
}
