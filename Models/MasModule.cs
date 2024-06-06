using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class MasModule
    {
        public int ModuleId { get; set; }
        public string? ModuleName { get; set; }
        public string? Module { get; set; }
        public string? Dll { get; set; }
        public string? MethodName { get; set; }
    }
}
