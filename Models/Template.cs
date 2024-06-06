using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class Template
    {
        public long Id { get; set; }
        public string? TemplateCode { get; set; }
        public string? Description { get; set; }
        public byte IsSms { get; set; }
        public string? Smstemplate { get; set; }
        public string? EmailTemplate { get; set; }
        public bool? IsActive { get; set; }
    }
}
