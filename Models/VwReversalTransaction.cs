using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class VwReversalTransaction
    {
        public string? ReversalStan { get; set; }
        public short? TranType { get; set; }
        public string? ReversalResponseCode { get; set; }
        public string? OriginalStan { get; set; }
        public string? ReversalResponseMsg { get; set; }
        public string? TerminalId { get; set; }
    }
}
