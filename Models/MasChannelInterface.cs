using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class MasChannelInterface
    {
        public int ChannelId { get; set; }
        public string? SourceId { get; set; }
        public string? ChannelName { get; set; }
        public string? SessionId { get; set; }
        public DateTime? SessionExpiry { get; set; }
    }
}
