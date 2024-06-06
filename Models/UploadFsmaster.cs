using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class UploadFsmaster
    {
        public long Id { get; set; }
        public int? FileType { get; set; }
        public string? FullFilePath { get; set; }
        public string? FileName { get; set; }
        public int? TotalCount { get; set; }
        public int? SuccessCount { get; set; }
        public int? FailedCount { get; set; }
        public int Status { get; set; }
        public string? Error { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
