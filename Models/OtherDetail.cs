using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class OtherDetail
    {
        public long OtherDetailId { get; set; }
        public int? RoleId { get; set; }
        public long? UserDetailId { get; set; }
        public string? Mid { get; set; }
        public string? Tid { get; set; }
        public string? ReceiptName { get; set; }
        public string? RcbcaccountNumber { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? PinCode { get; set; }
        public string? Nic { get; set; }
        public string? Mcc { get; set; }
        public int? TerminalType { get; set; }
        public int? ModelType { get; set; }
        public string? DeviceSerialNumber { get; set; }
    }
}
