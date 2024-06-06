using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TblMerchantDetail
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? MerchantId { get; set; }
        public string? TerminalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? IsChecked { get; set; }
    }
}
