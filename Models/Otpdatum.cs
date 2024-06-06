using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class Otpdatum
    {
        public long SrNo { get; set; }
        public string? TerminalId { get; set; }
        public string? MobileNo { get; set; }
        public string? Otp { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? LoginId { get; set; }
        public int TryCount { get; set; }
        public int Otplimit { get; set; }
        public DateTime? TryCountTime { get; set; }
        public DateTime? OtpsendTime { get; set; }
        public string? Otptype { get; set; }
    }
}
