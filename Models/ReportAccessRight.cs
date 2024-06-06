using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class ReportAccessRight
    {
        public long AccessRightsId { get; set; }
        public int RoleId { get; set; }
        public int? ReportTypeId { get; set; }
        public bool? IsAccessible { get; set; }
        public bool? IsActive { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
