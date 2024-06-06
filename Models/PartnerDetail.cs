using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class PartnerDetail
    {
        public int Id { get; set; }
        public string? PartnerCode { get; set; }
        public string? PartnerSessionId { get; set; }
        public string? PartnerPassword { get; set; }
        public string? PartnerMerchantId { get; set; }
        public string? PartnerLastpassword { get; set; }
        public DateTime? PasswordUpdatedDate { get; set; }
        public DateTime? PasswordReseton { get; set; }
        public string? PublicKey { get; set; }
        public string? PrevPublicKey { get; set; }
        public DateTime? PublicKeyCreatedOn { get; set; }
        public DateTime? PublicKeyExpiredOn { get; set; }
        public DateTime? PrevPubKeyActiveFrom { get; set; }
        public DateTime? PrevPubKeyExpiredOn { get; set; }
        public string? ClientId { get; set; }
        public string? ClientSecret { get; set; }
        public string? GrantType { get; set; }
        public string? Scope { get; set; }
        public long? RetrivalRefNo { get; set; }
        public int? ActiveTranCount { get; set; }
        public bool? IsPublicKeyUpdateLock { get; set; }
    }
}
