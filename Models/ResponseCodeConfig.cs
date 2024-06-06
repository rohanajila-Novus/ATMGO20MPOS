using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class ResponseCodeConfig
    {
        public int Id { get; set; }
        public string? TranType { get; set; }
        public string? ApiresponseCode { get; set; }
        public string? ApiresponseMsg { get; set; }
        public string? DbresponseCode { get; set; }
        public string? DbresponseMsg { get; set; }
        public string? ClientResponseCode { get; set; }
        public string? ClientResponseMsg { get; set; }
        public string? TranSubType { get; set; }
    }
}
