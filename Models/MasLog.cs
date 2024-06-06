using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class MasLog
    {
        public long LogId { get; set; }
        public string? RequestId { get; set; }
        public string? SourceId { get; set; }
        public string? TransType { get; set; }
        public string? Message { get; set; }
        public string? LogData { get; set; }
        public string? LogType { get; set; }
        public string? Params { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? LoggedFrom { get; set; }
        public string? LoggedRef { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
