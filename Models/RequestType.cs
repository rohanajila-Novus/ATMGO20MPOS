using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class RequestType
    {
        public int? RequestTypeId { get; set; }
        public string? RequestTypeDescription { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
