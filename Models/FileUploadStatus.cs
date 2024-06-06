using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class FileUploadStatus
    {
        public long Code { get; set; }
        public string StatusType { get; set; } = null!;
    }
}
