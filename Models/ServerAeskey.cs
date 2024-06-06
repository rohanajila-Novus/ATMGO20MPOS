using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class ServerAeskey
    {
        public decimal Id { get; set; }
        public string? Serverid { get; set; }
        public string? TerminalId { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Lastupdateddate { get; set; }
        public string? Aeskey { get; set; }
        public string? RandomNum { get; set; }
        public DateTime? RequestDatetime { get; set; }
        public int? Random3 { get; set; }
        public int? Random4 { get; set; }
        public int? Random6 { get; set; }
    }
}
