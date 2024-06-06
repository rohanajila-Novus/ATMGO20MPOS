using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class MasSwitchParam02012020
    {
        public int ParamId { get; set; }
        public string? ParamName { get; set; }
        public string? ParamValue { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsEditable { get; set; }
    }
}
