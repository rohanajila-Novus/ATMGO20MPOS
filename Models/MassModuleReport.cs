using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class MassModuleReport
    {
        public long MassModuleCode { get; set; }
        public string? ModuleName { get; set; }
        public int? Frequency { get; set; }
        public string? FrequencyUnit { get; set; }
        public bool? EnableState { get; set; }
        public short? Status { get; set; }
        public DateTime? LastRunTime { get; set; }
        public DateTime? NextRunDate { get; set; }
        public string? DllPath { get; set; }
        public string? ClassName { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? IssuerNum { get; set; }
        public string? MassDescription { get; set; }
        public int? RetryCount { get; set; }
    }
}
