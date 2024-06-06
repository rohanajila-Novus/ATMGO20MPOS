using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TerminalCounter
    {
        public int Id { get; set; }
        public string? TerminalId { get; set; }
        public int? TerminalStan { get; set; }
    }
}
