using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class DetHostParam
    {
        public string? TransType { get; set; }
        public int? HostId { get; set; }
        public string? ParamName { get; set; }
        public string? DataType { get; set; }
        public int? Length { get; set; }
        public short? Mandatory { get; set; }
        public string? AppVariable { get; set; }
        public string? Ioflag { get; set; }
        public string? DefaultValue { get; set; }
        public int Id { get; set; }
    }
}
