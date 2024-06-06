using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TranTypeRight
    {
        public int Id { get; set; }
        public string? MerchantId { get; set; }
        public string? TerminalId { get; set; }
        public int? TranType { get; set; }
        public bool? IsAccessible { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? Sequence { get; set; }
        public int? SubTranId { get; set; }
    }
}
