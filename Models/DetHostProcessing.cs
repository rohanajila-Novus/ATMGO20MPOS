using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class DetHostProcessing
    {
        public string? TransType { get; set; }
        public int? ChannelId { get; set; }
        public int? HostId { get; set; }
        public int? Sequence { get; set; }
        public string? HostTransType { get; set; }
        public int? TransSequence { get; set; }
        public bool? ContinueOnFail { get; set; }
    }
}
