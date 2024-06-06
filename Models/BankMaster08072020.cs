using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class BankMaster08072020
    {
        public long BankId { get; set; }
        public string? BankName { get; set; }
        public string? BankCode { get; set; }
        public bool IsActive { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? BanMnmonic { get; set; }
    }
}
