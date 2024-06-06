using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class SignOnLog
    {
        public int Id { get; set; }
        public string? Keys { get; set; }
        public string? CurrentValue { get; set; }
        public string? PreviousValue { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
