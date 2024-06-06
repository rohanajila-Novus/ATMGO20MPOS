using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class BinConfiguration02012020
    {
        public int BinId { get; set; }
        public long? Bin { get; set; }
        public string? Service { get; set; }
        public string? BankName { get; set; }
        public bool? Status { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
