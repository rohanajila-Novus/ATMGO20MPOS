using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class MasParamTemp
    {
        public int ParamId { get; set; }
        public string? ParamName { get; set; }
        public string? ParamValue { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsEditable { get; set; }
    }
}
