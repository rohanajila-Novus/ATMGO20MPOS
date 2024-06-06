using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class MasTransactionType
    {
        public long Id { get; set; }
        public string? TransType { get; set; }
        public string? TransDesc { get; set; }
        public short? Type { get; set; }
    }
}
