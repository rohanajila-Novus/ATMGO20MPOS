using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TblTerminal
    {
        public int SrId { get; set; }
        public string TerminalId { get; set; } = null!;
        public string TerminalName { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string? Pin { get; set; }
        public string MerchantId { get; set; } = null!;
        public bool? Active { get; set; }
        public DateTime? ActivatedOn { get; set; }
        public string? SwiperId { get; set; }
        public string? Imei { get; set; }
        public string? OneTimeLimit { get; set; }
        public string? DailyLimit { get; set; }
        public string? MonthlyLimit { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? BatchDate { get; set; }
        public string? Menu { get; set; }
        public bool? OtpFlag { get; set; }
        public string? OtpValue { get; set; }
        public string? TipFlag { get; set; }
        public string? VersionNo { get; set; }
        public string? Simid { get; set; }
        public byte[]? LogOnSessionKey { get; set; }
        public bool? ActiveLogOn { get; set; }
        public string? LogoPath { get; set; }
        public byte[]? SessionKey { get; set; }
        public byte[]? Logonkey { get; set; }
        public byte[]? UserPin { get; set; }
        public byte[]? AccountNo { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int Stan { get; set; }
        public string? Gcmid { get; set; }
        public string VcrRoCode { get; set; } = null!;
        public string? PlatformType { get; set; }
        public string? AppVer { get; set; }
        public string? ApayImei { get; set; }
        public string? ApayDeviceId { get; set; }
        public bool IsManualSettled { get; set; }
        public bool IsOnlineReversalReceiptPrint { get; set; }
        public string? TerminalMasterKey { get; set; }
        public string? TerminalSecondKey { get; set; }
        public string? DeviceSerialNumber { get; set; }
        public string? TerminalType { get; set; }
        public string? Model { get; set; }
        public DateTime? InstalledOperationalDate { get; set; }
        public string? CertificationUpload { get; set; }
        public string? PhoneSerialNumber { get; set; }
        public string? SmartNumber { get; set; }
        public string? SimSerialNumber { get; set; }
        public string? PrinterSerialNumber { get; set; }
        public string? MpospesaPodSerialNumber { get; set; }
        public string? Remarks { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public string? DeviceAddress { get; set; }
        public string? PictureFile { get; set; }
        public string? PictureFileBack { get; set; }
        public string? SignatureFile { get; set; }
        public bool? IsInstalled { get; set; }
        public long? InstalledBy { get; set; }
        public string? ShopPicture { get; set; }
        public string? OtherInfoPicture { get; set; }
        public string? FirmwareVersion { get; set; }
        public string? TerminalAddress { get; set; }
        public string? Name { get; set; }
    }
}
