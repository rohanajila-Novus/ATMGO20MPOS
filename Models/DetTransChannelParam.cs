using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class DetTransChannelParam
    {
        public int Id { get; set; }
        public string? TransType { get; set; }
        public string? ParamName { get; set; }
        public string? DataType { get; set; }
        public int? Length { get; set; }
        public bool? Mandatory { get; set; }
        public string? AppVariable { get; set; }
        public string? Ioflag { get; set; }
    }
}
