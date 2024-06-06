using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TblReferrerDetail
    {
        public int ReferrerId { get; set; }
        public string? ReferrerName { get; set; }
        public string? ReferrerEmail { get; set; }
        public string? ReferrerMobile { get; set; }
        public string? ReferrerAccountNumber { get; set; }
        public bool? IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
