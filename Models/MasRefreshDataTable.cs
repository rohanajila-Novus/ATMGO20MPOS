using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class MasRefreshDataTable
    {
        public int Id { get; set; }
        public string? TableName { get; set; }
        public int? TablePosition { get; set; }
        public bool? Active { get; set; }
    }
}
