using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class BinConfigurationQueue
    {
        public long Id { get; set; }
        public int? RequestTypeId { get; set; }
        public int? FormStatusId { get; set; }
        public long? MakerId { get; set; }
        public long? CheckerId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? Remark { get; set; }
        public long? BinId { get; set; }
        public long? Bin { get; set; }
        public string? Service { get; set; }
        public string? BankName { get; set; }
        public bool Status { get; set; }
    }
}
