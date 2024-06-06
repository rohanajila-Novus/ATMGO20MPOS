using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class BulkFileConfig
    {
        public long Id { get; set; }
        public string? FileType { get; set; }
        public string? IsMandatory { get; set; }
        public string? MinLen { get; set; }
        public string? MaxLen { get; set; }
        public string? FieldName { get; set; }
        public bool? IsNum { get; set; }
        public bool? IsAlpha { get; set; }
        public bool? IsAlphanumeric { get; set; }
        public bool? IsEmail { get; set; }
        public bool? IsDateValue { get; set; }
        public string? FixedValue { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
