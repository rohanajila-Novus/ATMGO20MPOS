using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class PageLink
    {
        public int PageLinkId { get; set; }
        public string? PageName { get; set; }
        public string? LinkName { get; set; }
        public string? LinkId { get; set; }
        public int? ParentLinkId { get; set; }
        public bool? IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsMakerCheckerEnabled { get; set; }
    }
}
