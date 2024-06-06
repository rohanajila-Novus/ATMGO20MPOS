using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class UploadBillerListHistory
    {
        public long Id { get; set; }
        public string? BillerName { get; set; }
        public string? AccountNumber { get; set; }
        public string? Address { get; set; }
        public string? MobileNumber { get; set; }
        public long? UploadId { get; set; }
        public string? UploadFileName { get; set; }
        public short? FileUploadStatus { get; set; }
        public string? ValidationMsg { get; set; }
        public DateTime? ProcessDate { get; set; }
        public short? IsSuccess { get; set; }
        public int? FileType { get; set; }
    }
}
