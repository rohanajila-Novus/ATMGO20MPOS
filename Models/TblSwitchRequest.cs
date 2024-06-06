using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TblSwitchRequest
    {
        public int Id { get; set; }
        public string? Stan { get; set; }
        public string? TerminalId { get; set; }
        public byte[]? RequestMsg { get; set; }
        public byte[]? ResponseMsg { get; set; }
        public bool? IsTimeOut { get; set; }
        public bool? IsProcessed { get; set; }
        public string? RequestId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsPending { get; set; }
    }
}
