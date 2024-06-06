using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class Masresponsecodes14102019
    {
        public int ResponseId { get; set; }
        public string ResponseCode { get; set; } = null!;
        public string? ResponseMessage { get; set; }
        public string? ResponseToClient { get; set; }
        public string? Reference { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? SwitchResponseCode { get; set; }
    }
}
