using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class Apikey
    {
        public int Id { get; set; }
        public int? Domain { get; set; }
        public string? Apikey1 { get; set; }
        public int? KeyLength { get; set; }
        public string? Privatekey1 { get; set; }
        public string? Publickey1 { get; set; }
        public string? Privatekey2 { get; set; }
        public string? Publickey2 { get; set; }
        public decimal? Vendorid { get; set; }
        public string? IpOrDomain { get; set; }
        public string? PrivatekeyLast1 { get; set; }
        public string? PublickeyLast1 { get; set; }
        public string? PrivatekeyLast2 { get; set; }
        public string? PublickeyLast2 { get; set; }
        public int? Status { get; set; }
        public string? VendorDescription { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public bool? EncRequired { get; set; }
        public bool? DecryRequired { get; set; }
        public string? EncType { get; set; }
        public bool? Schedule { get; set; }
        public DateTime? ScheduleTime { get; set; }
        public DateTime? ActivationTime { get; set; }
        public int? CountryId { get; set; }
        public string? Nextapikey { get; set; }
        public string? Action { get; set; }
        public bool? SwitchRequired { get; set; }
    }
}
