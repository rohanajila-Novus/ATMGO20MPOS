using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class RoleMaster10022020
    {
        public int RoleId { get; set; }
        public string? RoleDesc { get; set; }
        public bool IsActive { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsVisible { get; set; }
        public bool IsAccount { get; set; }
        public string? CustIdentity { get; set; }
        public string? CustIdlen { get; set; }
        public string? RemarkForDeleteRole { get; set; }
        public int? RoleCategory { get; set; }
    }
}
