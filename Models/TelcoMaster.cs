using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TelcoMaster
    {
        public long TelcoId { get; set; }
        public string? TelcoName { get; set; }
        public string? TelcoCode { get; set; }
        public bool? IsActive { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
