using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class BillerMasterQueue
    {
        public long Id { get; set; }
        public int? RequestTypeId { get; set; }
        public int? FormStatusId { get; set; }
        public long? MakerId { get; set; }
        public long? CheckerId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? Remark { get; set; }
        public long? BillerId { get; set; }
        public string? Institution { get; set; }
        public string? BillerCode { get; set; }
        public string? NameAppearOnAtmscreen { get; set; }
        public string? NamePrintedOnReceipt { get; set; }
        public string? DepositoryBank { get; set; }
        public bool? IsActive { get; set; }
        public string? AccountPrefix { get; set; }
        public int? BillerCategoryCode { get; set; }
        public int? AccountPrefixLength { get; set; }
        public int? AccountNumberLength { get; set; }
        public int? BillerType { get; set; }
        public string? MobileNumber { get; set; }
        public string? BillerAddress { get; set; }
        public string? AccountNumber { get; set; }
    }
}
