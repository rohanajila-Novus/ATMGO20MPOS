using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TranTypeRightsQueue
    {
        public long Id { get; set; }
        public int? RequestTypeId { get; set; }
        public int? FormStatusId { get; set; }
        public long? MakerId { get; set; }
        public long? CheckerId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? Remark { get; set; }
        public string? MerchantId { get; set; }
        public string? TerminalId { get; set; }
        public int? TranType { get; set; }
        public bool? IsAccessible { get; set; }
        public bool? IsActive { get; set; }
        public int? Sequence { get; set; }
        public int? SubTranId { get; set; }
    }
}
