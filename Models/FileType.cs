using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class FileType
    {
        public int Id { get; set; }
        public short? FileTypeId { get; set; }
        public string? FileType1 { get; set; }
        public int IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public string? InsertValidationSp { get; set; }
        public string? Seperator { get; set; }
    }
}
