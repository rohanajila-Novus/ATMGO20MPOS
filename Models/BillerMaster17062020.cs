using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class BillerMaster17062020
    {
        public long BillerId { get; set; }
        public string? Institution { get; set; }
        public string? BillerCode { get; set; }
        public string? NameAppearOnAtmscreen { get; set; }
        public string? NamePrintedOnReceipt { get; set; }
        public string? DepositoryBank { get; set; }
        public bool IsActive { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? AccountPrefix { get; set; }
        public int? BillerCategoryCode { get; set; }
        public int? AccountPrefixLength { get; set; }
        public int? AccountNumberLength { get; set; }
    }
}
