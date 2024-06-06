using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class SetPasswordLink
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public string? UniqueId { get; set; }
        public bool? IsActive { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? RequestFrom { get; set; }
    }
}
