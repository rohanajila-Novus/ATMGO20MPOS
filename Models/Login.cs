using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class Login
    {
        public long UserId { get; set; }
        public string? UserName { get; set; }
        public string? Mobile { get; set; }
        public string? UserPass { get; set; }
        public string? UserPass1 { get; set; }
        public string? UserPass2 { get; set; }
        public string? UserPass3 { get; set; }
        public string? SessionId { get; set; }
        public long? UserDetailId { get; set; }
        public int? RoleId { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public int MpintryCount { get; set; }
        public DateTime? MpinlockedOn { get; set; }
        public int TryCount { get; set; }
        public bool IsLocked { get; set; }
        public bool? IsActive { get; set; }
        public bool IsAccountClosed { get; set; }
        public bool Loggin { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? LastLogoutDate { get; set; }
        public DateTime LastPasswordChangedDt { get; set; }
        public bool IsPwdChanged { get; set; }
        public string? RemarkForLockUnlock { get; set; }
        public string? RemarkForActivateDeactivate { get; set; }
        public string? RemarkForDeleteUser { get; set; }
        public string? UserInternetProtocol { get; set; }
        public string? SourceId { get; set; }
        public string? Token { get; set; }
        public int? RoleCategory { get; set; }
        public DateTime? UserLockedOn { get; set; }
        public string? UserLockReason { get; set; }
        public int? PasswordTryCount { get; set; }
        public int? OtptryCount { get; set; }
        public string? TerminalId { get; set; }
        public byte[]? Mpin { get; set; }
        public string? MakeModel { get; set; }
        public string? Osversion { get; set; }
        public string? MobileVersion { get; set; }
        public string? SessionKey { get; set; }
        public string? RandomNum { get; set; }
        public string? UserPass4 { get; set; }
    }
}
