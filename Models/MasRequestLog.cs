using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class MasRequestLog
    {
        public long LogId { get; set; }
        public string? SourceId { get; set; }
        public string? TransType { get; set; }
        public string? Request { get; set; }
        public string? Response { get; set; }
        public DateTime? RequestDateTime { get; set; }
        public DateTime? ResponseDateTime { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? LoggedRef { get; set; }
    }
}
