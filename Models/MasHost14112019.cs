using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class MasHost14112019
    {
        public long Id { get; set; }
        public int HostId { get; set; }
        public string? HostShortName { get; set; }
        public string? HostDescription { get; set; }
        public string? Ip { get; set; }
        public int? Port { get; set; }
        public string? CommunicationMode { get; set; }
        public string? Message { get; set; }
        public short? PersistentConnection { get; set; }
        public string? RequestModule { get; set; }
        public string? RequestDll { get; set; }
        public string? RequestMethod { get; set; }
        public string? CommunioncationModule { get; set; }
        public string? CommunioncationDll { get; set; }
        public string? CommunioncationMethod { get; set; }
        public string? ResponseModule { get; set; }
        public string? ResponseDll { get; set; }
        public string? ResponseMethod { get; set; }
    }
}
