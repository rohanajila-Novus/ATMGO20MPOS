using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class ReportType
    {
        public int Id { get; set; }
        public string ReportName { get; set; } = null!;
        public bool? IsActive { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ShortName { get; set; }
    }
}
