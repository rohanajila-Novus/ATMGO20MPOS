using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TranType
    {
        public short TranTypeId { get; set; }
        public short? TranType1 { get; set; }
        public string? TranDescription { get; set; }
        public bool? IsActive { get; set; }
        public string? MasTransType { get; set; }
        public string? MasTranTypeVerify { get; set; }
        public string? Smsbody { get; set; }
        public string? EmailBody { get; set; }
    }
}
