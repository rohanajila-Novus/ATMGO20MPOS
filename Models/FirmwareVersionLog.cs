using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class FirmwareVersionLog
    {
        public int Id { get; set; }
        public string? TerminalId { get; set; }
        public string? CurrentVersion { get; set; }
        public string? PreviousVersion { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
