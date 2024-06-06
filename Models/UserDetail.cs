using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class UserDetail
    {
        public long UserDetailId { get; set; }
        public long? UserId { get; set; }
        public int? RoleId { get; set; }
        public string? FullName { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? Imeino { get; set; }
        public string? Gcmid { get; set; }
        public string? SerialId { get; set; }
        public string? DeviceName { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public string? CustomerId { get; set; }
        public bool IsAccountCreated { get; set; }
        public byte Fee { get; set; }
        public string? BankCode { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
    }
}
