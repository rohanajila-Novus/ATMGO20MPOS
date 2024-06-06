using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class DeviceBuildVersion
    {
        public int Id { get; set; }
        public string BuildVersion { get; set; } = null!;
        public string FileName { get; set; } = null!;
    }
}
