using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class MasParamQueue
    {
        public long Id { get; set; }
        public int? RequestTypeId { get; set; }
        public int? FormStatusId { get; set; }
        public long? MakerId { get; set; }
        public long? CheckerId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? Remark { get; set; }
        public long? ParamId { get; set; }
        public string? ParamName { get; set; }
        public string? ParamValue { get; set; }
        public string? Description { get; set; }
    }
}
