using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class DetTransProcessing
    {
        public long Id { get; set; }
        public string? TransType { get; set; }
        public int? ChannelId { get; set; }
        public int? ModuleId { get; set; }
        public int? Sequence { get; set; }
        public bool? IsCompulsory { get; set; }
    }
}
