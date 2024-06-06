﻿using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class ResetPasswordQueue
    {
        public long Id { get; set; }
        public int? RequestTypeId { get; set; }
        public int? FormStatusId { get; set; }
        public long? MakerId { get; set; }
        public long? CheckerId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? Remark { get; set; }
        public long? UserId { get; set; }
        public string? UserPass { get; set; }
    }
}
