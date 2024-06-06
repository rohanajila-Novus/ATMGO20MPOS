using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class SubTranMenu
    {
        public int? Id { get; set; }
        public int? TranTypeId { get; set; }
        public string? SubMenuDesc { get; set; }
        public int? Sequence { get; set; }
        public bool? IsActive { get; set; }
    }
}
